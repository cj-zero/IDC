using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using IDC.Application.Basics;
using SAPbobsCOM;
using IDC.Infrastructure.Returned;
using IDC.Application.WMS.Request;
using IDC.Repository.Entities.NsapBone;
using IDC.Repository.Entities.Sap;
using System.Linq;
using IDC.Application.SSO;
using IDC.Repository.Dapper;
using IDC.Infrastructure.AutoMapper;
using Dapper;

namespace IDC.Application.WMS
{
    /// <summary>
    /// WMS生产收货操作
    /// </summary>
    public class ProductReceiptApp: BaseApp
    {
        private readonly Company company;
        //static readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);//用信号量代替锁

        /// <summary>
        /// WMS同步生产收货
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public async Task<TableData> ProductReceiptHandle(AddOrUpdProductReceiptReq obj)
        {
            int eCode;
            string eMesg = "";
            string docNum = string.Empty;
            TableData result= new TableData();
            try
            {
                if (obj.ProductReceiptDetailReqs != null)//存在物料明细
                {
                    SAPbobsCOM.Documents dts = (SAPbobsCOM.Documents)company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenEntry);
                    #region [添加主表信息]
                    dts.DocDate = Convert.ToDateTime(obj.DocDate.Value);
                    dts.Comments = obj.Comments.ToString();
                    dts.JournalMemo = obj.JrnlMemo.ToString();
                    //扩展信息
                    if (!string.IsNullOrEmpty(obj.U_CPH))
                    {
                        dts.UserFields.Fields.Item("U_CPH").Value = obj.U_CPH;
                    }
                    if (!string.IsNullOrEmpty(obj.U_YSQX))
                    {
                        dts.UserFields.Fields.Item("U_YSQX").Value = obj.U_YSQX;
                    }
                    if (!string.IsNullOrEmpty(obj.U_ShipName))
                    {
                        dts.UserFields.Fields.Item("U_ShipName").Value = obj.U_ShipName;
                    }
                    if (!string.IsNullOrEmpty(obj.U_SMAZ))
                    {
                        dts.UserFields.Fields.Item("U_SMAZ").Value = obj.U_SMAZ;
                    }
                    //系统操作者
                    if (!string.IsNullOrEmpty(obj.U_YGMD) && obj.U_YGMD != "")
                    {
                        dts.UserFields.Fields.Item("U_YGMD").Value = obj.U_YGMD;
                    }
                    //领退料部门
                    if (!string.IsNullOrEmpty(obj.U_PRX_TkNo) && obj.U_PRX_TkNo != "")
                    {
                        dts.UserFields.Fields.Item("U_PRX_TkNo").Value = obj.U_PRX_TkNo;
                    }
                    #endregion

                    #region [添加行明细]
                    foreach (var ign1 in obj.ProductReceiptDetailReqs)
                    {
                        dts.Lines.BaseEntry = ign1.BaseEntry == null ? -1 : ign1.BaseEntry.Value;
                        //dts.Lines.BaseLine = ign1.LineNum;
                        dts.Lines.ItemDescription = ign1.Dscription;
                        dts.Lines.Quantity = double.Parse(ign1.Quantity.Value.ToString());
                        if (ign1.Price > 0)
                        {
                            dts.Lines.Price = double.Parse(ign1.Price.ToString());
                        }
                        dts.Lines.WarehouseCode = ign1.WhsCode;
                        dts.Lines.Add();
                    }

                    #endregion
                    var res = dts.Add();
                    if (res != 0)
                    {
                        company.GetLastError(out eCode, out eMesg);
                    }
                    else
                    {
                        company.GetNewObjectCode(out docNum);
                        eCode = 201;
                        eMesg = "SAP成功";
                    }
                }
                else
                {
                    eCode = 500;
                    eMesg = "添加生产收货到SAP时异常！错误代码：入库量为零";
                }
            }
            catch (Exception e)
            {
                eCode = 500;
                eMesg = "调用接口添加生产收货时异常：" + e.ToString() + "";
            }
            if (!string.IsNullOrWhiteSpace(eMesg))
            {
                result.Code= eCode;
                result.Message = eMesg;
            }
            //*/
            //eCode = 201;docNum = "26";
            if (eCode == 201)//SAP同步成功
            {
                try
                {
                    result=await ProductReceiptHandleERP3(int.Parse(docNum));
                }
                catch (Exception e)
                {
                    result.Code = 202;
                    result.Message ="SAP同步成功;ERP3.0同步失败:"+ e.ToString();
                }
            }
            return result;
        }
        /// <summary>
        /// WMS同步生产收货ERP端
        /// </summary>
        /// <param name="docNum"></param>
        /// <returns></returns>
        public async Task<TableData> ProductReceiptHandleERP3(int? docNum)
        {
            //string eMsg = string.Empty;
            TableData result = new TableData();
            StringBuilder updateStr = new StringBuilder();
            DynamicParameters mParams = new DynamicParameters();
            //var OIGNmodel = UnitWork.Find<OIGN>(o => o.DocEntry == docNum).FirstOrDefault();
            //var IGN1model = UnitWork.Find<IGN1>(o => o.DocEntry == docNum).ToList();
            try
            {
                #region 添加主数据,行明细
                string OIGNstr = string.Format(@"select * from OIGN where DocEntry={0}", docNum);
                var OIGNmodel = (await _repositoryBase.GetAsync<OIGN>(OIGNstr, null)).FirstOrDefault();
                product_oign theoign = OIGNmodel.MapTo<product_oign>();
                theoign.sbo_id = Define.Sbo_Id;
                updateStr.AppendFormat(@"INSERT INTO product_oign (sbo_id,DocEntry,DocNum,ObjType,DocDate,DocDueDate,DocType,DocCur,DocRate,DocTotal,Comments,JrnlMemo,TransId,UpdateDate,CreateDate,TaxDate,Ref1,SupplCode,U_YGMD,U_PRX_TkNo,U_job_id)
                VALUES (" + theoign.sbo_id + "," + docNum + "," + docNum + ",'" + theoign.ObjType + "','" + theoign.DocDate + "','" + theoign.DocDueDate + "','" + theoign.DocType + "','" + theoign.DocCur + "','" + theoign.DocRate + "','" + theoign.DocTotal
                + "','" + theoign.Comments + "','" + theoign.JrnlMemo + "','" + theoign.TransId + "','" + theoign.CreateDate + "','" + theoign.TaxDate + "','" + theoign.DocDate + "','" + theoign.Ref1 + "','" + theoign.SupplCode + "','" + theoign.U_YGMD + "','" + theoign.U_PRX_TkNo + "','" + theoign.U_job_id + "')");
                updateStr.AppendLine();
                updateStr.Append(@" ON Duplicate KEY UPDATE sbo_id=VALUES(sbo_id),DocEntry=VALUES(DocEntry),DocNum=VALUES(DocNum),ObjType=VALUES(ObjType),DocDate=VALUES(DocDate),DocDueDate=VALUES(DocDueDate),DocType=VALUES(DocType),DocCur=VALUES(DocCur),DocRate=VALUES(DocRate),DocTotal=VALUES(DocTotal),Comments=VALUES(Comments),JrnlMemo=VALUES(JrnlMemo),TransId=VALUES(TransId)," +
                "UpdateDate = VALUES(UpdateDate), CreateDate = VALUES(CreateDate), TaxDate = VALUES(TaxDate), Ref1 = VALUES(Ref1), SupplCode = VALUES(SupplCode), U_YGMD = VALUES(U_YGMD), U_PRX_TkNo = VALUES(U_PRX_TkNo), U_job_id = VALUES(U_job_id); ");
                await _repositoryBase.AddAsync<product_oign>(updateStr.ToString(), null);
                //明细
                updateStr.Clear();
                string IGN1str = string.Format(@"select * from IGN1 where DocEntry={0}", docNum);
                var IGN1model = (await _repositoryBase.GetAsync<IGN1>(IGN1str, null)).ToList();
                if (IGN1model.Count > 0)
                {
                    updateStr.AppendLine();
                    updateStr.Append(@"INSERT INTO product_ign1 (sbo_id,DocEntry,LineNum,BaseRef,BaseType,BaseEntry,BaseLine,ItemCode,Dscription,Quantity,OpenQty,Price,Currency,Rate,DiscPrcnt,LineTotal,OpenSum,WhsCode,AcctCode,GrossBuyPr,PriceBefDi,DocDate,OpenCreQty,
                            PriceAfVAT,FinncPriod,ObjType,VisOrder,INMPrice,TaxType,LineType,TranType,StockPrice,StockSum,BasePrice,DetailsOW,TaxOnly,unitMsr2,NumPerMsr2) VALUES ");
                    int i = 0;
                    foreach (IGN1 theign in IGN1model)
                    {
                        i++;
                        updateStr.AppendFormat("(?sbo_id{0},?DocEntry{0},?LineNum{0},?BaseRef{0},?BaseType{0},?BaseEntry{0},?BaseLine{0},?ItemCode{0},?Dscription{0},", i);
                        updateStr.AppendFormat("?Quantity{0},?OpenQty{0},?Price{0},?Currency{0},?Rate{0},?DiscPrcnt{0},?LineTotal{0},?OpenSum{0},?WhsCode{0},?AcctCode{0},?GrossBuyPr{0},?PriceBefDi{0},", i);
                        updateStr.AppendFormat("?DocDate{0},?OpenCreQty{0},?PriceAfVAT{0},?FinncPriod{0},?ObjType{0},?VisOrder{0},?INMPrice{0},?TaxType{0},?LineType{0},?TranType{0},?StockPrice{0},", i);
                        updateStr.AppendFormat("?StockSum{0},?BasePrice{0},?DetailsOW{0},?TaxOnly{0},?unitMsr2{0},?NumPerMsr2{0}){1}", i, IGN1model.Count == i ? "" : ",");
                        #region
                        mParams.Add(string.Format("?sbo_id{0}", i), Define.Sbo_Id);
                        mParams.Add(string.Format("?DocEntry{0}", i), docNum);
                        mParams.Add(string.Format("?LineNum{0}", i), theign.LineNum);
                        mParams.Add(string.Format("?BaseRef{0}", i), theign.BaseRef);
                        mParams.Add(string.Format("?BaseType{0}", i), theign.BaseType);
                        mParams.Add(string.Format("?BaseEntry{0}", i), theign.BaseEntry);
                        mParams.Add(string.Format("?BaseLine{0}", i), theign.BaseLine);
                        mParams.Add(string.Format("?ItemCode{0}", i), theign.ItemCode);
                        mParams.Add(string.Format("?Dscription{0}", i), theign.Dscription);
                        mParams.Add(string.Format("?Quantity{0}", i), theign.Quantity);
                        mParams.Add(string.Format("?OpenQty{0}", i), theign.OpenQty);
                        mParams.Add(string.Format("?Price{0}", i), theign.Price);
                        mParams.Add(string.Format("?Currency{0}", i), theign.Currency);
                        mParams.Add(string.Format("?Rate{0}", i), theign.Rate);
                        mParams.Add(string.Format("?DiscPrcnt{0}", i), theign.DiscPrcnt);
                        mParams.Add(string.Format("?LineTotal{0}", i), theign.LineTotal);
                        mParams.Add(string.Format("?OpenSum{0}", i), theign.OpenSum);
                        mParams.Add(string.Format("?WhsCode{0}", i), theign.WhsCode);
                        mParams.Add(string.Format("?AcctCode{0}", i), theign.AcctCode);
                        mParams.Add(string.Format("?GrossBuyPr{0}", i), theign.GrossBuyPr);
                        mParams.Add(string.Format("?PriceBefDi{0}", i), theign.PriceBefDi);
                        mParams.Add(string.Format("?DocDate{0}", i), theign.DocDate);
                        mParams.Add(string.Format("?OpenCreQty{0}", i), theign.OpenCreQty);
                        mParams.Add(string.Format("?PriceAfVAT{0}", i), theign.PriceAfVAT);
                        mParams.Add(string.Format("?FinncPriod{0}", i), theign.FinncPriod);
                        mParams.Add(string.Format("?ObjType{0}", i), theign.ObjType);
                        mParams.Add(string.Format("?VisOrder{0}", i), theign.VisOrder);
                        mParams.Add(string.Format("?INMPrice{0}", i), theign.INMPrice);
                        mParams.Add(string.Format("?TaxType{0}", i), theign.TaxType);
                        mParams.Add(string.Format("?LineType{0}", i), theign.LineType);
                        mParams.Add(string.Format("?TranType{0}", i), theign.TranType);
                        mParams.Add(string.Format("?StockPrice{0}", i), theign.StockPrice);
                        mParams.Add(string.Format("?StockSum{0}", i), theign.StockSum);
                        mParams.Add(string.Format("?BasePrice{0}", i), theign.BasePrice);
                        mParams.Add(string.Format("?DetailsOW{0}", i), theign.DetailsOW);
                        mParams.Add(string.Format("?TaxOnly{0}", i), theign.TaxOnly);
                        mParams.Add(string.Format("?unitMsr2{0}", i), theign.unitMsr2);
                        mParams.Add(string.Format("?NumPerMsr2{0}", i), theign.NumPerMsr2);
                        #endregion
                        i++;
                        updateStr.AppendLine();
                    }
                    updateStr.Append("ON Duplicate KEY UPDATE ");
                    updateStr.Append("sbo_id=VALUES(sbo_id),DocEntry=VALUES(DocEntry),LineNum=VALUES(LineNum),BaseRef=VALUES(BaseRef),BaseType=VALUES(BaseType),BaseEntry=VALUES(BaseEntry),");
                    updateStr.Append("BaseLine=VALUES(BaseLine),ItemCode=VALUES(ItemCode),Dscription=VALUES(Dscription),Quantity=VALUES(Quantity),OpenQty=VALUES(OpenQty),Price=VALUES(Price),");
                    updateStr.Append("Currency=VALUES(Currency),Rate=VALUES(Rate),DiscPrcnt=VALUES(DiscPrcnt),LineTotal=VALUES(LineTotal),OpenSum=VALUES(OpenSum),WhsCode=VALUES(WhsCode),");
                    updateStr.Append("AcctCode=VALUES(AcctCode),GrossBuyPr=VALUES(GrossBuyPr),PriceBefDi=VALUES(PriceBefDi),DocDate=VALUES(DocDate),OpenCreQty=VALUES(OpenCreQty),PriceAfVAT=VALUES(PriceAfVAT),");
                    updateStr.Append("FinncPriod=VALUES(FinncPriod),ObjType=VALUES(ObjType),VisOrder=VALUES(VisOrder),INMPrice=VALUES(INMPrice),TaxType=VALUES(TaxType),LineType=VALUES(LineType),");
                    updateStr.Append("TranType=VALUES(TranType),StockPrice=VALUES(StockPrice),StockSum=VALUES(StockSum),BasePrice=VALUES(BasePrice),DetailsOW=VALUES(DetailsOW),TaxOnly=VALUES(TaxOnly),");
                    updateStr.Append("unitMsr2=VALUES(unitMsr2),NumPerMsr2=VALUES(NumPerMsr2);");
                }
                await _repositoryBase.BatchAddAsync<product_ign1>(updateStr.ToString(), mParams);
                #endregion
                updateStr.Clear();
                #region 修改库存量 
                if (IGN1model.Count > 0)
                {
                    foreach (IGN1 theign in IGN1model)
                    {
                        #region wor dev
                        //oitw
                        var woritemstr = string.Format("select onHand,IsCommited,onOrder,itemcode,whscode from OITW where itemcode='{0}' and whsCode='{1}'", theign.ItemCode.Replace("'", "''"), theign.WhsCode);
                        var woritemObj = (await _repositoryBase.GetAsync<OITW>(woritemstr, null)).ToList();
                        if (woritemObj.Count > 0)
                        {
                            updateStr.AppendFormat($@"update store_oitw set OnHand={woritemObj[0].OnHand},IsCommited={woritemObj[0].IsCommited},OnOrder={woritemObj[0].OnOrder} where ItemCode='{woritemObj[0].ItemCode.Replace("'", "''")}' and WhsCode='{woritemObj[0].WhsCode}' and sbo_id={Define.Sbo_Id};");
                            updateStr.AppendLine();
                        }
                        //oitm
                        woritemstr = string.Format($@"select onHand,IsCommited,onOrder,LastPurDat,LastPurPrc,LastPurCur,UpdateDate,itemcode from OITM where itemcode='{theign.ItemCode.Replace("'","''")}'");
                        var woritemObj1 = (await _repositoryBase.GetAsync<OITM>(woritemstr, null)).ToList();
                        if (woritemObj1.Count > 0)
                        {
                            updateStr.AppendFormat($@"update store_oitm set OnHand={woritemObj1[0].OnHand},IsCommited={woritemObj1[0].IsCommited},OnOrder={woritemObj1[0].OnOrder},LastPurDat='{woritemObj1[0].LastPurDat}'
                                ,LastPurPrc={woritemObj1[0].LastPurPrc},LastPurCur='{woritemObj1[0].LastPurCur}',UpdateDate='{woritemObj1[0].UpdateDate}' where ItemCode='{woritemObj1[0].ItemCode.Replace("'", "''")}' and sbo_id={Define.Sbo_Id};");
                            updateStr.AppendLine();
                        }
                        #endregion
                        #region wor detail
                        if (theign.BaseEntry != null && theign.BaseEntry > 0)
                        {
                            string wordetailsql = string.Format(@"select w.ItemCode,w.WhsCode,w.OnHand,w.IsCommited,w.OnOrder FROM WOR1  w1 left outer join 
                                oitw w on w.ItemCode=w1.ItemCode and w.WhsCode=w1.wareHouse where w1.DocEntry={0}", theign.BaseEntry);
                            var wordetailobj = (await _repositoryBase.GetAsync<OITW>(wordetailsql, null)).ToList();
                            foreach (var tdtl in wordetailobj)
                            {
                                updateStr.AppendFormat($@"update store_oitw set OnHand={tdtl.OnHand},IsCommited={tdtl.IsCommited},OnOrder={tdtl.OnOrder} where ItemCode='{tdtl.ItemCode.Replace("'", "''")}' and WhsCode='{tdtl.WhsCode}' and sbo_id={Define.Sbo_Id};");
                                updateStr.AppendLine();
                            }
                            wordetailsql = string.Format(@"select i.ItemCode,i.OnHand,i.IsCommited,i.OnOrder,i.LastPurDat,i.LastPurPrc,i.LastPurCur,i.UpdateDate FROM WOR1 w1 left outer join 
                                oitm i on i.ItemCode=w1.ItemCode where w1.DocEntry={0}", theign.BaseEntry);
                            var wordetailobj1 = (await _repositoryBase.GetAsync<OITM>(wordetailsql, null)).ToList();
                            foreach (var tdtl in wordetailobj1)
                            {
                                updateStr.AppendFormat($@"update store_oitm set OnHand={tdtl.OnHand},IsCommited={tdtl.IsCommited},OnOrder={tdtl.OnOrder},LastPurDat='{tdtl.LastPurDat}'
                                ,LastPurPrc={tdtl.LastPurPrc},LastPurCur='{tdtl.LastPurCur}',UpdateDate='{tdtl.UpdateDate}' where ItemCode='{tdtl.ItemCode.Replace("'", "''")}' and sbo_id={Define.Sbo_Id};");
                                updateStr.AppendLine();
                            }
                        }
                        #endregion
                        if (updateStr.Length > 0)
                        {
                            await _repositoryBase.BatchAddAsync<store_oitm>(updateStr.ToString(), null);
                        }
                    }
                }
                #endregion
                updateStr.Clear();
                #region OITL
                string oitlstr = string.Format($@"select * from oitl where docType=59 and DocEntry={docNum}");
                var oitlModel = (await _repositoryBase.GetAsync<OITL>(oitlstr, null)).ToList();
                List<store_oitl> theoitl = oitlModel.MapToList<store_oitl>();
                theoitl.ForEach(s => s.sbo_id = Define.Sbo_Id);
                string addoitl= @"INSERT INTO store_oitl(LogEntry, TransId, ItemCode, ItemName, ManagedBy, DocEntry, 
                        DocLine, DocType, DocNum, BaseEntry, BaseLine, BaseType, ApplyEntry, ApplyLine, ApplyType, DocDate, CardCode, CardName, DocQty, StockQty, 
                        DefinedQty, StockEff, CreateDate, LocType, LocCode, AppDocNum, VersionNum, Transfered, Instance, SubLineNum, BSubLineNo, AppSubLine, ActBaseTp, 
                        ActBaseEnt, ActBaseLn, ActBasSubL, AllocateTp, AllocatEnt, AllocateLn, sbo_id) VALUES (@LogEntry, @TransId, @ItemCode, @ItemName, @ManagedBy, @DocEntry, 
                        @DocLine, @DocType, @DocNum, BaseEntry, @BaseLine, @BaseType, @ApplyEntry, @ApplyLine, @ApplyType, @DocDate, @CardCode, @CardName, @DocQty, @StockQty, 
                        @DefinedQty, @StockEff, @CreateDate, @LocType, @LocCode, @AppDocNum, @VersionNum, @Transfered, @Instance, @SubLineNum, @BSubLineNo, @AppSubLine, @ActBaseTp, 
                        @ActBaseEnt, @ActBaseLn, @ActBasSubL, @AllocateTp, @AllocatEnt, @AllocateLn, @sbo_id)
                        ON DUPLICATE KEY UPDATE sbo_id=VALUES(sbo_id),LogEntry=VALUES(LogEntry),TransId=VALUES(TransId),ItemCode=VALUES(ItemCode),ItemName=VALUES(ItemName),ManagedBy=VALUES(ManagedBy),DocEntry=VALUES(DocEntry),
                        DocLine=VALUES(DocLine),DocType=VALUES(DocType),DocNum=VALUES(DocNum),BaseEntry=VALUES(BaseEntry),BaseLine=VALUES(BaseLine),BaseType=VALUES(BaseType),ApplyEntry=VALUES(ApplyEntry),
                        ApplyLine=VALUES(ApplyLine),ApplyType=VALUES(ApplyType),DocDate=VALUES(DocDate),CardCode=VALUES(CardCode),CardName=VALUES(CardName),DocQty=VALUES(DocQty),StockQty=VALUES(StockQty),
                        DefinedQty=VALUES(DefinedQty),StockEff=VALUES(StockEff),CreateDate=VALUES(CreateDate),LocType=VALUES(LocType),LocCode=VALUES(LocCode),AppDocNum=VALUES(AppDocNum),VersionNum=VALUES(VersionNum),
                        Transfered=VALUES(Transfered),Instance=VALUES(Instance),SubLineNum=VALUES(SubLineNum),BSubLineNo=VALUES(BSubLineNo),AppSubLine=VALUES(AppSubLine),ActBaseTp=VALUES(ActBaseTp),ActBaseEnt=VALUES(ActBaseEnt),
                        ActBaseLn=VALUES(ActBaseLn),ActBasSubL=VALUES(ActBasSubL),AllocateTp=VALUES(AllocateTp),AllocatEnt=VALUES(AllocatEnt),AllocateLn=VALUES(AllocateLn);";
                await _repositoryBase.BatchAddAsync<store_oitl>(addoitl, theoitl);
                //detail
                var itl1sql = @$"select a.* from itl1 a  left join oitl  b on a.LogEntry=b.LogEntry where b.docentry={docNum} and b.doctype=59";
                var itl1Model = await _repositoryBase.GetAsync<ITL1>(itl1sql);
                List<store_itl1> utl1List = itl1Model.MapToList<store_itl1>();
                utl1List.ForEach(s => s.sbo_id = Define.Sbo_Id);
                string additl1sql = @"INSERT INTO store_itl1(LogEntry, ItemCode, SysNumber, Quantity, AllocQty, MdAbsEntry,ReleaseQty, PickedQty, sbo_id) VALUES 
                        (@LogEntry, @ItemCode, @SysNumber, @Quantity, @AllocQty, @MdAbsEntry, @ReleaseQty, @PickedQty, @sbo_id)
                         ON Duplicate KEY UPDATE sbo_id=VALUES(sbo_id),LogEntry=VALUES(LogEntry),ItemCode=VALUES(ItemCode),SysNumber=VALUES(SysNumber),Quantity=VALUES(Quantity),AllocQty=VALUES(AllocQty),MdAbsEntry=VALUES(MdAbsEntry),ReleaseQty=VALUES(ReleaseQty),PickedQty=VALUES(PickedQty);";
                await _repositoryBase.BatchAddAsync<store_itl1>(additl1sql, utl1List);
                //osrn
                List<store_osrn> osrnList = new List<store_osrn>();
                if (utl1List.Count > 0)
                {
                    var disitlList = utl1List.GroupBy(g => new { g.sbo_id, g.ItemCode, g.SysNumber }).Select(s => s.First());
                    foreach (store_itl1 theitl1 in disitlList)
                    {
                        string osrnstr = string.Format(@"select ItemCode,SysNumber,DistNumber,MnfSerial,LotNumber,ExpDate,MnfDate,InDate,GrntStart,GrntExp,CreateDate,Location,Status,Notes,DataSource,Transfered,Instance,AbsEntry,ObjType,itemName,LogInstanc,UpdateDate from OSRN WHERE ItemCode='{0}' AND SysNumber={1}", theitl1.ItemCode.Replace("'", "''"), theitl1.SysNumber);
                        var osrnModel = (await _repositoryBase.GetAsync<OSRN>(osrnstr)).FirstOrDefault();
                        if (osrnModel != null)
                        {
                            store_osrn temposrn = osrnModel.MapTo<store_osrn>();
                            temposrn.sbo_id = Define.Sbo_Id;
                            osrnList.Add(temposrn);
                        }
                    }
                    if (osrnList.Count > 0)
                    {
                        string srnUpdSq = @"INSERT INTO store_osrn (sbo_id,ItemCode,SysNumber,DistNumber,MnfSerial,LotNumber,ExpDate,MnfDate,InDate,GrntStart,GrntExp,CreateDate,Location,Status,Notes,DataSource,Transfered,Instance,AbsEntry,ObjType,itemName,LogInstanc,UpdateDate) VALUES (
                                @sbo_id, @ItemCode, @SysNumber, @DistNumber, @MnfSerial, @LotNumber, @ExpDate, @MnfDate, @InDate, @GrntStart, @GrntExp, @CreateDate, @Location, @Status, @Notes, @DataSource, @Transfered, @Instance, @AbsEntry, @ObjType, @itemName, @LogInstanc, @UpdateDate) 
                                ON DUPLICATE KEY UPDATE sbo_id=VALUES(sbo_id),ItemCode=VALUES(ItemCode),SysNumber=VALUES(SysNumber),DistNumber=VALUES(DistNumber),MnfSerial=VALUES(MnfSerial),LotNumber=VALUES(LotNumber),ExpDate=VALUES(ExpDate),MnfDate=VALUES(MnfDate),InDate=VALUES(InDate),GrntStart=VALUES(GrntStart),
                                GrntExp=VALUES(GrntExp),CreateDate=VALUES(CreateDate),Location=VALUES(Location),Status=VALUES(Status),Notes=VALUES(Notes),DataSource=VALUES(DataSource),Transfered=VALUES(Transfered),Instance=VALUES(Instance),AbsEntry=VALUES(AbsEntry),ObjType=VALUES(ObjType),itemName=VALUES(itemName),LogInstanc=VALUES(LogInstanc),UpdateDate=VALUES(UpdateDate);";
                        await _repositoryBase.BatchAddAsync<store_osrn>(srnUpdSq, osrnList);

                    }
                }
                #endregion
                updateStr.Clear();
                #region 修改生产订单
                var groupignList = (IGN1model.Where(w => w.BaseEntry != -1)).GroupBy(g => g.BaseEntry).Select(s => s.First());
                foreach (var theign in groupignList)
                {
                    if (theign.BaseEntry != null && theign.BaseEntry > 0)
                    {
                        string strSqlOWOAR = string.Format("SELECT DocEntry,Status,Type,CmpltQty,RjctQty FROM  OWOR WHERE DocEntry={0}", theign.BaseEntry);
                        var OWORModel = (await _repositoryBase.FindAsync<OWOR>(strSqlOWOAR, null)).FirstOrDefault();
                        //product_owor theowor = OWORModel.MapTo<product_owor>();
                        if (OWORModel != null)
                        {
                            updateStr.AppendFormat("UPDATE product_owor SET Status='{0}',Type='{1}',CmpltQty={2},RjctQty={3} WHERE sbo_id={4} AND DocEntry={5};", OWORModel.Status, OWORModel.Type, OWORModel.CmpltQty, OWORModel.RjctQty, Define.Sbo_Id, OWORModel.DocEntry);
                            updateStr.AppendLine();
                        };
                        string strSqlwor1 = string.Format("SELECT DocEntry,LineNum,ItemCode,BaseQty,PlannedQty,IssuedQty,IssueType,wareHouse,VisOrder FROM WOR1 WHERE DocEntry={0}", theign.BaseEntry);
                        var worModel = (await _repositoryBase.FindAsync<WOR1>(strSqlwor1, null)).ToList();
                        //List<product_wor1> theworList = worModel.MapToList<product_wor1>();
                        if (worModel.Count > 0)
                        {
                            foreach (var thewor1 in worModel)
                            {
                                updateStr.AppendFormat("UPDATE product_wor1 SET BaseQty={3},PlannedQty={4},IssuedQty={5}  WHERE sbo_id={0} AND DocEntry={1} AND ItemCode='{2}';", Define.Sbo_Id, thewor1.DocEntry, thewor1.ItemCode.Replace("'", "''")
                                    , thewor1.BaseQty, thewor1.PlannedQty, thewor1.IssuedQty);
                                updateStr.AppendLine();
                            }

                        }
                    }
                }
                if (updateStr.Length > 0)
                {
                    await _repositoryBase.BatchAddAsync<product_oign>(updateStr.ToString());
                }

                #endregion

                result.Code = 200;
                result.Data = new
                {
                    DocEntry = docNum,
                    SerialList= osrnList.Select(s=>new { s.ItemCode, s.SysNumber,s.MnfSerial,s.DistNumber}).ToList()
                };
                result.Message = "SAP同步成功;ERP同步成功";
            }
            catch (Exception ex)
            {
                result.Code = 202;
                result.Message = "SAP同步成功;ERP同步失败:" + ex.ToString();
            }
            return result;
        }


        public ProductReceiptApp(IRepositoryBase repositoryBase, Company oCompany, IAuth auth) : base(auth, repositoryBase)
        {
            company = oCompany;
        }
    }
}
