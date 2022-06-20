using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class SalesDeliveryApp : BaseApp
    {
        private readonly Company company;
        StockTransferApp stockApp;

        public async Task<TableData> GetSerialInfoByMnfSearialNo(string mnfSerialNo)
        {
            TableData result = new TableData();
            string selsql = string.Format(@"select t0.baseType,t0.BaseEntry, r.ItemCode,r.itemName,r.SysNumber,r.MnfSerial,r.DistNumber,r.InDate,r.GrntStart,r.GrntExp from OSRN r
                left outer join ITL1 t1 on r.ItemCode=t1.ItemCode and r.SysNumber=t1.SysNumber
                left outer join OITL t0 on t1.LogEntry=t0.LogEntry
                where (t0.DocType=59 or t0.DocType=20) and r.MnfSerial='{0}'", mnfSerialNo);
            var  theE= await _repositoryBase.DetailAsync<OITL>(selsql);
            result.Data = theE;
            return result;
        }

        public async Task<TableData> SalesDeliveryHandle(AddOrUpdSalesDeliveryReq obj)
        {
            int eCode; string eMesg = "";
            string docNum = string.Empty;
            TableData result = new TableData();

            if (company != null)
            {
                try
                {
                    SAPbobsCOM.Documents dts = (SAPbobsCOM.Documents)company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oDeliveryNotes);
                    #region 添加主表信息
                    dts.CardCode = obj.CardCode;
                    dts.DocDate = DateTime.Parse(obj.DocDate);
                    dts.Comments = obj.Comments;
                    dts.ContactPersonCode = int.Parse(obj.CntctCode == "" ? "0" : obj.CntctCode);
                    dts.SalesPersonCode = int.Parse(obj.SlpCode == "" ? "-1" : obj.SlpCode);
                    dts.NumAtCard = obj.NumAtCard;
                    dts.PayToCode = obj.PayToCode;
                    dts.ShipToCode = obj.ShipToCode;
                    dts.DocCurrency = obj.DocCur;
                    dts.DocDate = DateTime.Parse(obj.DocDate);
                    dts.DocDueDate = DateTime.Parse(obj.DocDueDate);
                    dts.TaxDate = DateTime.Parse(obj.TaxDate);
                    if (!string.IsNullOrEmpty(obj.TrnspCode))
                    {
                        dts.TransportationCode = Convert.ToInt32(obj.TrnspCode);
                    }
                    if (!string.IsNullOrEmpty(obj.OwnerCode))
                    {
                        dts.DocumentsOwner = Convert.ToInt32(obj.OwnerCode);
                    }
                    if (obj.PartSupply == "true")
                    {
                        dts.PartialSupply = BoYesNoEnum.tYES;
                    }
                    else
                    {
                        dts.PartialSupply = BoYesNoEnum.tNO;
                    }
                    if (!string.IsNullOrEmpty(obj.U_FPLB) && obj.U_FPLB != "")
                    {
                        dts.UserFields.Fields.Item("U_FPLB").Value = obj.U_FPLB;
                    }
                    if (!string.IsNullOrEmpty(obj.U_SL) && obj.U_SL != "")
                    {
                        dts.UserFields.Fields.Item("U_SL").Value = obj.U_SL;
                    }
                    if (!string.IsNullOrEmpty(obj.U_YWY) && obj.U_YWY != "")
                    {
                        dts.UserFields.Fields.Item("U_YWY").Value = obj.U_YWY;
                    }
                    if (!string.IsNullOrEmpty(obj.DocType))
                    {
                        if (obj.DocType == "I")
                            dts.DocType = BoDocumentTypes.dDocument_Items;
                        if (obj.DocType == "S")
                            dts.DocType = BoDocumentTypes.dDocument_Service;
                    }
                    else { dts.DocType = BoDocumentTypes.dDocument_Items; }

                    dts.Address2 = obj.Address2;      //收货方
                    dts.Address = obj.Address;        //收款方
                   
                    if (!string.IsNullOrEmpty(obj.GroupNum))
                    {
                        dts.PaymentGroupCode = int.Parse(obj.GroupNum);   //付款条款
                    }
                    dts.Indicator = obj.Indicator;    // 标识
                    dts.PaymentMethod = obj.PeyMethod;    //付款方式
                    dts.FederalTaxID = obj.LicTradNum;  //国税编号
                    dts.Project = "";
                    if (!string.IsNullOrEmpty(obj.DiscPrcnt))
                    {
                        dts.DiscountPercent = double.Parse(obj.DiscPrcnt);
                    }
                    if (!string.IsNullOrEmpty(obj.DocTotal))
                    {
                        dts.DocTotal = double.Parse(obj.DocTotal);
                    }
                    if (!string.IsNullOrEmpty(obj.U_CPH) && obj.U_CPH != "")
                    {
                        dts.UserFields.Fields.Item("U_CPH").Value = obj.U_CPH;
                    }
                    if (!string.IsNullOrEmpty(obj.U_YSQX) && obj.U_YSQX != "")
                    {
                        dts.UserFields.Fields.Item("U_YSQX").Value = obj.U_YSQX;
                    }
                    if (!string.IsNullOrEmpty(obj.U_THYY) && obj.U_THYY != "")
                    {
                        dts.UserFields.Fields.Item("U_THYY").Value = obj.U_THYY;
                    }
                    #endregion

                    #region 添加明细
                    foreach (BillSalesDetails dln1 in obj.billSalesDetails)
                    {
                        dts.Lines.ItemCode = dln1.ItemCode.Replace("&#92;", "■");
                        if (!string.IsNullOrEmpty(dln1.BaseLine))
                        {
                            dts.Lines.BaseEntry = int.Parse(dln1.BaseEntry == "" ? "-1" : dln1.BaseEntry);
                            dts.Lines.BaseLine = int.Parse(dln1.BaseLine);
                            dts.Lines.BaseType = int.Parse(dln1.BaseType == "" ? "-1" : dln1.BaseType);
                        }
                        dts.Lines.SalesPersonCode = int.Parse(obj.SlpCode == "" ? "-1" : obj.SlpCode);
                        dts.Lines.ItemDescription = dln1.Dscription;
                        dts.Lines.Quantity = System.Convert.ToDouble(dln1.Quantity);
                        dts.Lines.UnitPrice = double.Parse(string.IsNullOrWhiteSpace(dln1.PriceBefDi) ? "0" : dln1.PriceBefDi);            //单价
                        dts.Lines.Price = double.Parse(string.IsNullOrWhiteSpace(dln1.PriceBefDi) ? "0" : dln1.PriceBefDi);
                        dts.Lines.DiscountPercent = string.IsNullOrWhiteSpace(dln1.DiscPrcnt) ? 0.00 : double.Parse(dln1.DiscPrcnt);
                        dts.Lines.LineTotal = string.IsNullOrWhiteSpace(dln1.LineTotal) ? 0.00 : double.Parse(dln1.LineTotal);
                        dts.Lines.WarehouseCode = dln1.WhsCode == "" ? "01" : dln1.WhsCode;
                        if (stockApp.ExistNoDisNum(dln1.ItemCode))
                        {
                            int i = 0;
                            foreach (BillSerialNumberChooseItem serial in dln1.ChoosedSerialNumberList)
                            {
                                int sysnum = Convert.ToInt32(serial.SysSerial);
                                dts.Lines.SerialNumbers.SystemSerialNumber = sysnum;
                                dts.Lines.SerialNumbers.ManufacturerSerialNumber = serial.SuppSerial;
                                dts.Lines.SerialNumbers.SetCurrentLine(i);
                                dts.Lines.SerialNumbers.Add();
                                i++;
                            }
                        }
                        dts.Lines.VatGroup = "X0";
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
                catch (Exception e)
                {
                    eCode = 500;
                    eMesg = "调用接口添加生产收货时异常：" + e.ToString() + "";
                }
            }
            else
            {
                eCode = 500;
                eMesg = "链接SAP失败";
            }

            if (!string.IsNullOrWhiteSpace(eMesg))
            {
                result.Code = eCode;
                result.Message = eMesg;
            }

            if (eCode == 201)//SAP同步成功
            {
                try
                {
                    result = await SalesDeliveryHandleERP3(int.Parse(docNum));
                }
                catch (Exception e)
                {
                    result.Code = 202;
                    result.Message = "SAP同步成功;ERP3.0同步失败:" + e.ToString();
                }
            }
            return result;
        }
        public async Task<TableData> SalesDeliveryHandleERP3(int? docNum)
        {
            TableData result = new TableData();
            StringBuilder updateStr = new StringBuilder();
            DynamicParameters mParams = new DynamicParameters();
            try
            {
                #region 添加主数据
                string odlnsql = string.Format(@"select * from ODLN where DocEntry={0}", docNum);
                var owtrModel = (await _repositoryBase.GetAsync<ODLN>(odlnsql)).FirstOrDefault();
                sale_odln theodln = owtrModel.MapTo<sale_odln>();
                theodln.sbo_id = Define.Sbo_Id;
                theodln.DocEntry = docNum.Value.ToString();
                updateStr.AppendFormat(@"INSERT INTO sale_odln (sbo_id,DocEntry,DocNum,DocType,Printed,DocStatus,ObjType,DocDate,DocDueDate,CardCode,CardName,Address,NumAtCard,VatSum,DiscPrcnt,DiscSum,DocCur,DocRate,DocTotal,PaidToDate,GrosProfit,Comments,JrnlMemo,GroupNum,SlpCode,TrnspCode,PartSupply,
                    CurSource,UpdateDate,CreateDate,TaxDate,TotalExpns,Address2,Indicator,ShipToCode,LicTradNum,PeyMethod,Ref1,PayToCode,TransId,CntctCode,CtlAccount,SupplCode,OwnerCode,U_YWY,U_SL,U_FPLB,DiscSumFC,DocTotalFC,U_CPH,U_YSQX,U_THYY)values
                    (@sbo_id,@DocEntry,@DocNum,@DocType,@Printed,@DocStatus,@ObjType,@DocDate,@DocDueDate,@CardCode,@CardName,@Address,@NumAtCard,@VatSum,@DiscPrcnt,@DiscSum,@DocCur,@DocRate,@DocTotal,@PaidToDate,@GrosProfit,@Comments,@JrnlMemo,@GroupNum,@SlpCode,@TrnspCode,@PartSupply,
                    @CurSource,@UpdateDate,@CreateDate,@TaxDate,@TotalExpns,@Address2,@Indicator,@ShipToCode,@LicTradNum,@PeyMethod,@Ref1,@PayToCode,@TransId,@CntctCode,@CtlAccount,@SupplCode,@OwnerCode,@U_YWY,@U_SL,@U_FPLB,@DiscSumFC,@DocTotalFC,@U_CPH,@U_YSQX,@U_THYY)
                    ON Duplicate KEY UPDATE sbo_id=VALUES(sbo_id),DocEntry=VALUES(DocEntry),DocNum=VALUES(DocNum),DocType=VALUES(DocType),Printed=VALUES(Printed),DocStatus=VALUES(DocStatus),
                    ObjType=VALUES(ObjType),DocDate=VALUES(DocDate),DocDueDate=VALUES(DocDueDate),CardCode=VALUES(CardCode),CardName=VALUES(CardName),Address=VALUES(Address),NumAtCard=VALUES(NumAtCard),VatSum=VALUES(VatSum),DiscPrcnt=VALUES(DiscPrcnt),DiscSum=VALUES(DiscSum),DocCur=VALUES(DocCur),DocRate=VALUES(DocRate),
                    DocTotal=VALUES(DocTotal),PaidToDate=VALUES(PaidToDate),GrosProfit=VALUES(GrosProfit),Comments=VALUES(Comments),JrnlMemo=VALUES(JrnlMemo),GroupNum=VALUES(GroupNum),SlpCode=VALUES(SlpCode),TrnspCode=VALUES(TrnspCode),PartSupply=VALUES(PartSupply),CurSource=VALUES(CurSource),UpdateDate=VALUES(UpdateDate),CreateDate=VALUES(CreateDate),
                    TaxDate=VALUES(TaxDate),TotalExpns=VALUES(TotalExpns),Address2=VALUES(Address2),Indicator=VALUES(Indicator),ShipToCode=VALUES(ShipToCode),LicTradNum=VALUES(LicTradNum),PeyMethod=VALUES(PeyMethod),Ref1=VALUES(Ref1),PayToCode=VALUES(PayToCode),CntctCode=VALUES(CntctCode),CtlAccount=VALUES(CtlAccount),SupplCode=VALUES(SupplCode),
                    OwnerCode=VALUES(OwnerCode),U_YWY=VALUES(U_YWY),U_SL=VALUES(U_SL),U_FPLB=VALUES(U_FPLB),DiscSumFC=VALUES(DiscSumFC),DocTotalFC=VALUES(DocTotalFC)");
                await _repositoryBase.AddAsync<store_owtr>(updateStr.ToString(), theodln);
                updateStr.Clear();
                #endregion

                #region 添加行数据
                odlnsql = string.Format(@"select * from DLN1 where DocEntry={0}", docNum);
                var dlnModel = (await _repositoryBase.GetAsync<DLN1>(odlnsql)).ToList();
                List<sale_dln1> dlnList = dlnModel.MapToList<sale_dln1>();
                dlnList.ForEach(w => w.sbo_id = Define.Sbo_Id);
                dlnList.ForEach(w => w.DocEntry = docNum.Value);
                updateStr.AppendFormat(@"INSERT INTO sale_dln1 (sbo_id,DocEntry,LineNum,TargetType,TrgetEntry,BaseRef,BaseType,BaseEntry,BaseLine,LineStatus,ItemCode,Dscription,Quantity,Price,Currency,Rate,DiscPrcnt,LineTotal,TotalFrgn,WhsCode,SlpCode,GrossBuyPr,PriceBefDi,DocDate,
                VatPrcnt,VatGroup,PriceAfVAT,StockPrice,OpenQty,OpenSum,AcctCode,OrderedQty,TrnsCode,PackQty,BaseCard,StockValue,GTotal,unitMsr,NumPerMsr,LineVat,INMPrice,VisOrder,GrssProfit,FinncPriod,ObjType,OpenCreQty,U_PDXX,U_XSTCBL,U_SCTCBL,U_YFTCBL,U_YWF,U_FWF,U_YF,U_SHJSDJ,U_SHJSJ,U_SHTC) VALUES 
                (@sbo_id,@DocEntry,@LineNum,@TargetType,@TrgetEntry,@BaseRef,@BaseType,@BaseEntry,@BaseLine,@LineStatus,@ItemCode,@Dscription,@Quantity,@Price,@Currency,@Rate,@DiscPrcnt,@LineTotal,@TotalFrgn,@WhsCode,@SlpCode,@GrossBuyPr,@PriceBefDi,@DocDate,
                @VatPrcnt,@VatGroup,@PriceAfVAT,@StockPrice,@OpenQty,@OpenSum,@AcctCode,@OrderedQty,@TrnsCode,@PackQty,@BaseCard,@StockValue,@GTotal,@unitMsr,@NumPerMsr,@LineVat,@INMPrice,@VisOrder,@GrssProfit,@FinncPriod,@ObjType,@OpenCreQty,@U_PDXX,@U_XSTCBL,@U_SCTCBL,@U_YFTCBL,@U_YWF,@U_FWF,@U_YF,@U_SHJSDJ,@U_SHJSJ,@U_SHTC)
                 ON Duplicate KEY UPDATE sbo_id=VALUES(sbo_id),DocEntry=VALUES(DocEntry),LineNum=VALUES(LineNum),TargetType=VALUES(TargetType),TrgetEntry=VALUES(TrgetEntry),BaseRef=VALUES(BaseRef),BaseType=VALUES(BaseType),
                BaseEntry=VALUES(BaseEntry),BaseLine=VALUES(BaseLine),LineStatus=VALUES(LineStatus),ItemCode=VALUES(ItemCode),Dscription=VALUES(Dscription),
                Quantity=VALUES(Quantity),Price=VALUES(Price),Currency=VALUES(Currency),Rate=VALUES(Rate),DiscPrcnt=VALUES(DiscPrcnt),LineTotal=VALUES(LineTotal),TotalFrgn=VALUES(TotalFrgn),
                WhsCode=VALUES(WhsCode),SlpCode=VALUES(SlpCode),GrossBuyPr=VALUES(GrossBuyPr),PriceBefDi=VALUES(PriceBefDi),DocDate=VALUES(DocDate),VatPrcnt=VALUES(VatPrcnt),
                VatGroup=VALUES(VatGroup),PriceAfVAT=VALUES(PriceAfVAT),StockPrice=VALUES(StockPrice),OpenQty=VALUES(OpenQty),OpenSum=VALUES(OpenSum),AcctCode=VALUES(AcctCode),OrderedQty=VALUES(OrderedQty),
                TrnsCode=VALUES(TrnsCode),PackQty=VALUES(PackQty),BaseCard=VALUES(BaseCard),StockValue=VALUES(StockValue),GTotal=VALUES(GTotal),unitMsr=VALUES(unitMsr),
                NumPerMsr=VALUES(NumPerMsr),LineVat=VALUES(LineVat),INMPrice=VALUES(INMPrice),VisOrder=VALUES(VisOrder),GrssProfit=VALUES(GrssProfit),FinncPriod=VALUES(FinncPriod),
                ObjType=VALUES(ObjType),OpenCreQty=VALUES(OpenCreQty),U_PDXX=VALUES(U_PDXX),U_XSTCBL=VALUES(U_XSTCBL),U_SCTCBL=VALUES(U_SCTCBL),U_YFTCBL=VALUES(U_YFTCBL),U_YWF=VALUES(U_YWF),U_FWF=VALUES(U_FWF),U_YF=VALUES(U_YF),
                U_SHJSDJ=VALUES(U_SHJSDJ),U_SHJSJ=VALUES(U_SHJSJ),U_SHTC=VALUES(U_SHTC)");
                await _repositoryBase.BatchAddAsync<sale_dln1>(updateStr.ToString(), dlnList);
                updateStr.Clear();
                #endregion

                #region 修改库存量
                if (dlnList != null && dlnList.Count > 0)
                {
                    foreach (sale_dln1 thedln in dlnList)
                    {
                        //oitw fromTowarehouse
                        var oitwstr = string.Format("select onHand,IsCommited,onOrder,itemcode,whscode from OITW where itemcode='{0}' and (whsCode='{1}') ", thedln.ItemCode.Replace("'", "''"), thedln.WhsCode);
                        var oitwObj = (await _repositoryBase.GetAsync<OITW>(oitwstr, null)).ToList();
                        if (oitwObj.Count > 0)
                        {
                            foreach (OITW thisoitw in oitwObj)
                            {
                                updateStr.AppendFormat($@"update store_oitw set OnHand={thisoitw.OnHand},IsCommited={thisoitw.IsCommited},OnOrder={thisoitw.OnOrder} where ItemCode='{thisoitw.ItemCode.Replace("'", "''")}' and WhsCode='{thisoitw.WhsCode}' and sbo_id={Define.Sbo_Id};");
                                updateStr.AppendLine();
                            }
                        }
                        //oitm
                        oitwstr = string.Format($@"select onHand,IsCommited,onOrder,LastPurDat,LastPurPrc,LastPurCur,UpdateDate,itemcode from OITM where itemcode='{thedln.ItemCode.Replace("'", "''")}'");
                        var oitwObj1 = (await _repositoryBase.GetAsync<OITM>(oitwstr, null)).ToList();
                        if (oitwObj1.Count > 0)
                        {
                            updateStr.AppendFormat($@"update store_oitm set OnHand={oitwObj1[0].OnHand},IsCommited={oitwObj1[0].IsCommited},OnOrder={oitwObj1[0].OnOrder},LastPurDat='{oitwObj1[0].LastPurDat}'
                                ,LastPurPrc={oitwObj1[0].LastPurPrc},LastPurCur='{oitwObj1[0].LastPurCur}',UpdateDate='{oitwObj1[0].UpdateDate}' where ItemCode='{oitwObj1[0].ItemCode.Replace("'", "''")}' and sbo_id={Define.Sbo_Id};");
                            updateStr.AppendLine();
                        }

                        if (updateStr.Length > 0)
                        {
                            await _repositoryBase.BatchAddAsync<store_oitm>(updateStr.ToString(), null);
                            updateStr.Clear();
                        }
                    }
                }
                #endregion

                #region OITL
                string oitlstr = string.Format($@"select * from oitl where docType=15 and DocEntry={docNum}");
                var oitlModel = (await _repositoryBase.GetAsync<OITL>(oitlstr, null)).ToList();
                if (oitlModel.Count > 0)
                {
                    List<store_oitl> theoitl = oitlModel.MapToList<store_oitl>();
                    theoitl.ForEach(s => s.sbo_id = Define.Sbo_Id);
                    string addoitl = @"INSERT INTO store_oitl(LogEntry, TransId, ItemCode, ItemName, ManagedBy, DocEntry, 
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
                    var itl1sql = @$"select a.* from itl1 a  left join oitl  b on a.LogEntry=b.LogEntry where b.docentry={docNum} and b.doctype=15";
                    var itl1Model = await _repositoryBase.GetAsync<ITL1>(itl1sql);
                    List<store_itl1> itl1List = itl1Model.MapToList<store_itl1>();
                    itl1List.ForEach(s => s.sbo_id = Define.Sbo_Id);
                    string additl1sql = @$"INSERT INTO store_itl1(LogEntry, ItemCode, SysNumber, Quantity, AllocQty, MdAbsEntry,ReleaseQty, PickedQty, sbo_id) VALUES 
                        (@LogEntry, @ItemCode, @SysNumber, @Quantity, @AllocQty, @MdAbsEntry, @ReleaseQty, @PickedQty, @sbo_id)
                         ON Duplicate KEY UPDATE sbo_id=VALUES(sbo_id),LogEntry=VALUES(LogEntry),ItemCode=VALUES(ItemCode),SysNumber=VALUES(SysNumber),Quantity=VALUES(Quantity),AllocQty=VALUES(AllocQty),MdAbsEntry=VALUES(MdAbsEntry),ReleaseQty=VALUES(ReleaseQty),PickedQty=VALUES(PickedQty);";
                    await _repositoryBase.BatchAddAsync<store_itl1>(additl1sql, itl1List);
                    //osrn
                    if (itl1List.Count > 0)
                    {
                        var disitlList = itl1List.GroupBy(g => new { g.sbo_id, g.ItemCode, g.SysNumber }).Select(s => s.First());
                        List<store_osrn> osrnList = new List<store_osrn>();
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
                }
                #endregion

                #region 修改销售订单
                var baseE = dlnList.Where(w => w.BaseType == 17).GroupBy(g => g.BaseType).Select(s => s.First()).FirstOrDefault();
                if (baseE!=null)
                {
                    string ordrsql= string.Format(@"select * from ordr where DocEntry={0}", baseE.BaseEntry);
                    var ordrModel= (await _repositoryBase.GetAsync<ORDR>(ordrsql)).FirstOrDefault();
                    sale_ordr theordr = ordrModel.MapTo<sale_ordr>();
                    theordr.sbo_id = Define.Sbo_Id;
                    theordr.DocEntry = baseE.BaseEntry.Value;
                    #region 修改订单主数据
                    updateStr.AppendFormat(@"INSERT INTO sale_ordr(sbo_id,DocEntry,DocNum,DocType,Printed,DocStatus,DocDate,DocDueDate,CardCode,CardName,Address,VatSum,DiscPrcnt,DiscSum,DocCur,DocRate,DocTotal,PaidToDate,GrosProfit
                        ,Comments,GroupNum,SlpCode,PartSupply,UpdateDate,CreateDate,TaxDate,Address2,Indicator,CANCELED,InvntSttus) values 
                        (@sbo_id,@DocEntry,@DocNum,@DocType,@Printed,@DocStatus,@DocDate,@DocDueDate,@CardCode,@CardName,@Address,@VatSum,@DiscPrcnt,@DiscSum,@DocCur,@DocRate,@DocTotal,@PaidToDate,@GrosProfit,@Comments,@GroupNum,@SlpCode,@PartSupply,
                        @UpdateDate,@CreateDate,@TaxDate,@Address2,@Indicator,@CANCELED,@InvntSttus)
                        ON Duplicate KEY UPDATE sbo_id=VALUES(sbo_id),DocEntry=VALUES(DocEntry),DocNum=VALUES(DocNum),DocType=VALUES(DocType),Printed=VALUES(Printed),DocStatus=VALUES(DocStatus),DocDate=VALUES(DocDate),DocDueDate=VALUES(DocDueDate),CardCode=VALUES(CardCode),CardName=VALUES(CardName),Address=VALUES(Address),
                        VatSum=VALUES(VatSum),DiscPrcnt=VALUES(DiscPrcnt),DiscSum=VALUES(DiscSum),DocCur=VALUES(DocCur),DocRate=VALUES(DocRate),DocTotal=VALUES(DocTotal),PaidToDate=VALUES(PaidToDate),GrosProfit=VALUES(GrosProfit),Comments=VALUES(Comments),GroupNum=VALUES(GroupNum),
                        SlpCode=VALUES(SlpCode),PartSupply=VALUES(PartSupply),UpdateDate=VALUES(UpdateDate),CreateDate=VALUES(CreateDate),TaxDate=VALUES(TaxDate),Address2=VALUES(Address2),Indicator=VALUES(Indicator),CANCELED=VALUES(CANCELED),InvntSttus=VALUES(InvntSttus)
                    ");
                    await _repositoryBase.AddAsync<sale_ordr>(updateStr.ToString(), theordr);
                    updateStr.Clear();
                    #endregion

                    #region 修改销售订单行数据
                    var rdrModel= (await _repositoryBase.GetAsync<RDR1>("select * from rdr1 where DocEntry="+ baseE.BaseEntry)).ToList();
                    List<sale_rdr1> rdrList = rdrModel.MapToList<sale_rdr1>();
                    rdrList.ForEach(s => s.sbo_id = Define.Sbo_Id);
                    updateStr.AppendFormat(@"INSERT INTO sale_rdr1 (sbo_id,DocEntry,LineNum,LineStatus,ItemCode,Dscription,Quantity,Price,Currency,Rate,DiscPrcnt,
                        LineTotal,TotalFrgn,WhsCode,PriceBefDi,DocDate,PriceAfVAT,StockPrice,OpenQty,OpenSum,AcctCode,OrderedQty,
                        PackQty,BaseCard,StockValue,GTotal,unitMsr,LineVat,INMPrice,VisOrder,GrssProfit,OpenCreQty,InvntSttus) VALUES (@sbo_id,@DocEntry,@LineNum,@LineStatus,@ItemCode,@Dscription,@Quantity,@Price,@Currency,@Rate,@DiscPrcnt,
                        @LineTotal,@TotalFrgn,@WhsCode,@PriceBefDi,@DocDate,@PriceAfVAT,@StockPrice,@OpenQty,@OpenSum,@AcctCode,@OrderedQty,
                        @PackQty,@BaseCard,@StockValue,@GTotal,@unitMsr,@LineVat,@INMPrice,@VisOrder,@GrssProfit,@OpenCreQty,@InvntSttus)
                        ON Duplicate KEY UPDATE 
                        sbo_id=VALUES(sbo_id),DocEntry=VALUES(DocEntry),LineNum=VALUES(LineNum),LineStatus=VALUES(LineStatus),ItemCode=VALUES(ItemCode),Dscription=VALUES(Dscription),
                        Quantity=VALUES(Quantity),Price=VALUES(Price),Currency=VALUES(Currency),Rate=VALUES(Rate),DiscPrcnt=VALUES(DiscPrcnt),LineTotal=VALUES(LineTotal),TotalFrgn=VALUES(TotalFrgn),
                        WhsCode=VALUES(WhsCode),PriceBefDi=VALUES(PriceBefDi),DocDate=VALUES(DocDate),VatPrcnt=VALUES(VatPrcnt),
                        PriceAfVAT=VALUES(PriceAfVAT),StockPrice=VALUES(StockPrice),OpenQty=VALUES(OpenQty),OpenSum=VALUES(OpenSum),AcctCode=VALUES(AcctCode),OrderedQty=VALUES(OrderedQty),
                        PackQty=VALUES(PackQty),BaseCard=VALUES(BaseCard),StockValue=VALUES(StockValue),GTotal=VALUES(GTotal),unitMsr=VALUES(unitMsr),
                        LineVat=VALUES(LineVat),INMPrice=VALUES(INMPrice),VisOrder=VALUES(VisOrder),GrssProfit=VALUES(GrssProfit),
                        OpenCreQty=VALUES(OpenCreQty),InvntSttus=VALUES(InvntSttus)");

                    await _repositoryBase.BatchAddAsync<sale_rdr1>(updateStr.ToString(), rdrList);
                    updateStr.Clear();
                    #endregion
                }
                #endregion
                result.Code = 200;
                result.Message = "SAP同步成功;ERP同步成功";
            }
            catch (Exception ex)
            {
                result.Code = 202;
                result.Message = "SAP同步成功;ERP同步失败:" + ex.ToString();
            }
            return result;
        }

        public SalesDeliveryApp(IRepositoryBase repositoryBase, Company oCompany, IAuth auth,StockTransferApp _stApp) : base(auth, repositoryBase)
        {
            company = oCompany;
            stockApp = _stApp;
        }
    }
}
