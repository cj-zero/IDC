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
    public class StockTransferApp:BaseApp
    {
        private readonly Company company;

        public async Task<TableData> StockTransferHandle(AddOrUpdStockTransferReq obj)
        {
            int eCode;string eMesg = "";
            string docNum = string.Empty;
            TableData result = new TableData();
            if (company != null)
            {
                try
                {
                    SAPbobsCOM.StockTransfer dts =(SAPbobsCOM.StockTransfer)company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oStockTransfer);

                    #region [添加主表信息]
                    dts.CardCode = obj.CardCode;
                    dts.DocDate = DateTime.Parse(obj.DocDate);
                    dts.Comments = obj.Comments;
                    dts.ContactPerson = int.Parse(obj.CntctCode == "" ? "0" : obj.CntctCode);
                    dts.SalesPersonCode = int.Parse(obj.SlpCode == "" ? "-1" : obj.SlpCode);
                    dts.DocDate = DateTime.Parse(obj.DocDate);
                    dts.TaxDate = DateTime.Parse(obj.TaxDate);
                    dts.Address = obj.Address;        //收货方
                    dts.FromWarehouse = obj.Filler == "" ? "01" : obj.Filler;
                    dts.ToWarehouse=obj.WhsCode == "" ? "01" : obj.WhsCode;
                    if (!string.IsNullOrEmpty(obj.U_YGMD) && obj.U_YGMD != "")
                    {
                        dts.UserFields.Fields.Item("U_YGMD").Value = obj.U_YGMD;
                    }
                    if (!string.IsNullOrEmpty(obj.U_CPH) && obj.U_CPH != "")
                    {
                        dts.UserFields.Fields.Item("U_CPH").Value = obj.U_CPH;
                    }
                    if (!string.IsNullOrEmpty(obj.U_YSQX) && obj.U_YSQX != "")
                    {
                        dts.UserFields.Fields.Item("U_YSQX").Value = obj.U_YSQX;
                    }
                    #endregion

                    #region [添加行明细]
                    foreach (StockTransferDetail wtr1 in obj.billStockDetails)
                    {
                        dts.Lines.ItemCode = wtr1.ItemCode.Replace("&#92;", "■");
                        dts.Lines.ItemDescription = wtr1.Dscription;
                        dts.Lines.Quantity = System.Convert.ToDouble(wtr1.Quantity);
                        dts.Lines.WarehouseCode = wtr1.WhsCode == "" ? "01" : wtr1.WhsCode;
                        //如果物料是序列号管理,则选择对应数量序列号
                        if (ExistNoDisNum(wtr1.ItemCode))
                        {
                            int i = 0;
                            foreach (BillSerialNumberChooseItem osrn in wtr1.ChoosedSerialNumberList)
                            {
                                int sysnum = Convert.ToInt32(osrn.SysSerial);
                                dts.Lines.SerialNumbers.SystemSerialNumber = sysnum;
                                dts.Lines.SerialNumbers.ManufacturerSerialNumber = osrn.SuppSerial;
                                dts.Lines.SerialNumbers.InternalSerialNumber = System.Convert.ToString(i + 3);
                                dts.Lines.SerialNumbers.SetCurrentLine(i);
                                dts.Lines.SerialNumbers.Add();
                                i++;
                            }
                        }
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
                result.Code= eCode;
                result.Message = eMesg;
            }
           
            if (eCode == 201)//SAP同步成功
            {
                try
                {
                    result = await StockTransferHandleERP3(int.Parse(docNum));
                }
                catch (Exception e)
                {
                    result.Code = 202;
                    result.Message = "SAP同步成功;ERP3.0同步失败:" + e.ToString();
                }
            }
            return result;
        }

        public async Task<TableData> StockTransferHandleERP3(int? docNum)
        {
            TableData result = new TableData();
            StringBuilder updateStr = new StringBuilder();
            DynamicParameters mParams = new DynamicParameters();
            try
            {
                #region 添加主数据
                string owtrsql = string.Format(@"select * from OWTR where DocEntry={0}", docNum);
                var owtrModel = (await _repositoryBase.GetAsync<OWTR>(owtrsql)).FirstOrDefault();
                store_owtr theowtr = owtrModel.MapTo<store_owtr>();
                theowtr.sbo_id = Define.Sbo_Id;
                theowtr.DocEntry = docNum.Value;
                updateStr.AppendFormat(@"INSERT INTO store_owtr (sbo_id,DocEntry,DocNum,DocType,Printed,DocStatus,ObjType,DocDate,DocDueDate,CardCode,CardName,Address,NumAtCard,VatSum,DiscPrcnt,DiscSum,DocCur,DocRate,DocTotal,PaidToDate,GrosProfit,Comments,JrnlMemo,GroupNum,SlpCode,PartSupply,
                    CurSource,UpdateDate,CreateDate,TaxDate,TotalExpns,Address2,Indicator,ShipToCode,LicTradNum,PeyMethod,Ref1,PayToCode,CntctCode,CtlAccount,SupplCode,OwnerCode,CANCELED,U_YGMD,Filler,U_CPH,U_YSQX)VALUES (@sbo_id,@DocEntry,@DocNum,@DocType,@Printed,@DocStatus,@ObjType,@DocDate,@DocDueDate,@CardCode,@CardName,@Address,@NumAtCard,@VatSum,@DiscPrcnt,@DiscSum,@DocCur,@DocRate,@DocTotal,@PaidToDate,@GrosProfit,@Comments,@JrnlMemo,@GroupNum,@SlpCode,@PartSupply,
                    @CurSource,@UpdateDate,@CreateDate,@TaxDate,@TotalExpns,@Address2,@Indicator,@ShipToCode,@LicTradNum,@PeyMethod,@Ref1,@PayToCode,@CntctCode,@CtlAccount,@SupplCode,@OwnerCode,@CANCELED,@U_YGMD,@Filler,@U_CPH,@U_YSQX)
                    ON Duplicate KEY UPDATE sbo_id=VALUES(sbo_id),DocEntry=VALUES(DocEntry),DocNum=VALUES(DocNum),DocType=VALUES(DocType),Printed=VALUES(Printed),DocStatus=VALUES(DocStatus),ObjType=VALUES(ObjType),DocDate=VALUES(DocDate),DocDueDate=VALUES(DocDueDate),CardCode=VALUES(CardCode),CardName=VALUES(CardName),Address=VALUES(Address),
                    NumAtCard=VALUES(NumAtCard),VatSum=VALUES(VatSum),DiscPrcnt=VALUES(DiscPrcnt),DiscSum=VALUES(DiscSum),DocCur=VALUES(DocCur),DocRate=VALUES(DocRate),DocTotal=VALUES(DocTotal),PaidToDate=VALUES(PaidToDate),GrosProfit=VALUES(GrosProfit),Comments=VALUES(Comments),JrnlMemo=VALUES(JrnlMemo),GroupNum=VALUES(GroupNum),
                    SlpCode=VALUES(SlpCode),PartSupply=VALUES(PartSupply),CurSource=VALUES(CurSource),UpdateDate=VALUES(UpdateDate),CreateDate=VALUES(CreateDate),TaxDate=VALUES(TaxDate),TotalExpns=VALUES(TotalExpns),Address2=VALUES(Address2),Indicator=VALUES(Indicator),ShipToCode=VALUES(ShipToCode),LicTradNum=VALUES(LicTradNum),
                    PeyMethod=VALUES(PeyMethod),Ref1=VALUES(Ref1),PayToCode=VALUES(PayToCode),CntctCode=VALUES(CntctCode),CtlAccount=VALUES(CtlAccount),SupplCode=VALUES(SupplCode),OwnerCode=VALUES(OwnerCode),CANCELED=VALUES(CANCELED),Filler=VALUES(Filler)");
                await _repositoryBase.AddAsync<store_owtr>(updateStr.ToString(), theowtr);
                updateStr.Clear();
                #endregion

                #region 添加行数据
                owtrsql = string.Format(@"select * from WTR1 where DocEntry={0}", docNum);
                var wtrModel = (await _repositoryBase.GetAsync<WTR1>(owtrsql)).ToList();
                List<store_wtr1> wtrList = wtrModel.MapToList<store_wtr1>();
                wtrList.ForEach(w => w.sbo_id = Define.Sbo_Id) ;
                wtrList.ForEach(w => w.DocEntry = docNum.Value);
                updateStr.AppendFormat(@"INSERT INTO store_wtr1 (sbo_id,DocEntry,LineNum,TargetType,TrgetEntry,BaseRef,BaseType,BaseEntry,BaseLine,LineStatus,ItemCode,Dscription,Quantity,Price,Currency,Rate,DiscPrcnt,LineTotal,TotalFrgn,WhsCode,
                    SlpCode,GrossBuyPr,PriceBefDi,DocDate,VatPrcnt,VatGroup,PriceAfVAT,StockPrice,OpenQty,OpenSum,AcctCode,OrderedQty,TrnsCode,PackQty,BaseCard,StockValue,GTotal,unitMsr,NumPerMsr,LineVat,INMPrice,VisOrder,GrssProfit,FinncPriod,ObjType,OpenCreQty,U_PDXX) VALUES (
                    @sbo_id,@DocEntry,@LineNum,@TargetType,@TrgetEntry,@BaseRef,@BaseType,@BaseEntry,@BaseLine,@LineStatus,@ItemCode,@Dscription,@Quantity,@Price,@Currency,@Rate,@DiscPrcnt,@LineTotal,@TotalFrgn,@WhsCode,
                    @SlpCode,@GrossBuyPr,@PriceBefDi,@DocDate,@VatPrcnt,@VatGroup,@PriceAfVAT,@StockPrice,@OpenQty,@OpenSum,@AcctCode,@OrderedQty,@TrnsCode,@PackQty,@BaseCard,@StockValue,@GTotal,@unitMsr,@NumPerMsr,@LineVat,@INMPrice,@VisOrder,@GrssProfit,@FinncPriod,@ObjType,@OpenCreQty,@U_PDXX)
                    ON Duplicate KEY UPDATE sbo_id=VALUES(sbo_id),DocEntry=VALUES(DocEntry),LineNum=VALUES(LineNum),TargetType=VALUES(TargetType),TrgetEntry=VALUES(TrgetEntry),BaseRef=VALUES(BaseRef),BaseType=VALUES(BaseType),BaseEntry=VALUES(BaseEntry),BaseLine=VALUES(BaseLine),LineStatus=VALUES(LineStatus),ItemCode=VALUES(ItemCode),Dscription=VALUES(Dscription),
                    Quantity=VALUES(Quantity),Price=VALUES(Price),Currency=VALUES(Currency),Rate=VALUES(Rate),DiscPrcnt=VALUES(DiscPrcnt),LineTotal=VALUES(LineTotal),TotalFrgn=VALUES(TotalFrgn),WhsCode=VALUES(WhsCode),SlpCode=VALUES(SlpCode),GrossBuyPr=VALUES(GrossBuyPr),PriceBefDi=VALUES(PriceBefDi),DocDate=VALUES(DocDate),VatPrcnt=VALUES(VatPrcnt),
                    VatGroup=VALUES(VatGroup),PriceAfVAT=VALUES(PriceAfVAT),StockPrice=VALUES(StockPrice),OpenQty=VALUES(OpenQty),OpenSum=VALUES(OpenSum),AcctCode=VALUES(AcctCode),OrderedQty=VALUES(OrderedQty),TrnsCode=VALUES(TrnsCode),PackQty=VALUES(PackQty),BaseCard=VALUES(BaseCard),StockValue=VALUES(StockValue),GTotal=VALUES(GTotal),unitMsr=VALUES(unitMsr),
                    NumPerMsr=VALUES(NumPerMsr),LineVat=VALUES(LineVat),INMPrice=VALUES(INMPrice),VisOrder=VALUES(VisOrder),GrssProfit=VALUES(GrssProfit),FinncPriod=VALUES(FinncPriod),ObjType=VALUES(ObjType),OpenCreQty=VALUES(OpenCreQty),U_PDXX=VALUES(U_PDXX)");
                await _repositoryBase.BatchAddAsync<store_wtr1>(updateStr.ToString(), wtrList);
                updateStr.Clear();
                #endregion

                #region 修改库存量
                if (theowtr!=null && wtrList.Count > 0)
                {
                    foreach (store_wtr1 thetwr in wtrList)
                    {
                        //oitw fromTowarehouse
                        var oitwstr = string.Format("select onHand,IsCommited,onOrder,itemcode,whscode from OITW where itemcode='{0}' and (whsCode='{1}' or whsCode='{2}') ", thetwr.ItemCode.Replace("'", "''"), thetwr.WhsCode,theowtr.Filler);
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
                        oitwstr = string.Format($@"select onHand,IsCommited,onOrder,LastPurDat,LastPurPrc,LastPurCur,UpdateDate,itemcode from OITM where itemcode='{thetwr.ItemCode.Replace("'", "''")}'");
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
                string oitlstr = string.Format($@"select * from oitl where docType=67 and DocEntry={docNum}");
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
                    var itl1sql = @$"select a.* from itl1 a  left join oitl  b on a.LogEntry=b.LogEntry where b.docentry={docNum} and b.doctype=67";
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
                        foreach(store_itl1 theitl1 in disitlList)
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
                        if (osrnList.Count>0)
                        {
                            string srnUpdSq= @"INSERT INTO store_osrn (sbo_id,ItemCode,SysNumber,DistNumber,MnfSerial,LotNumber,ExpDate,MnfDate,InDate,GrntStart,GrntExp,CreateDate,Location,Status,Notes,DataSource,Transfered,Instance,AbsEntry,ObjType,itemName,LogInstanc,UpdateDate) VALUES (
                                @sbo_id, @ItemCode, @SysNumber, @DistNumber, @MnfSerial, @LotNumber, @ExpDate, @MnfDate, @InDate, @GrntStart, @GrntExp, @CreateDate, @Location, @Status, @Notes, @DataSource, @Transfered, @Instance, @AbsEntry, @ObjType, @itemName, @LogInstanc, @UpdateDate) 
                                ON DUPLICATE KEY UPDATE sbo_id=VALUES(sbo_id),ItemCode=VALUES(ItemCode),SysNumber=VALUES(SysNumber),DistNumber=VALUES(DistNumber),MnfSerial=VALUES(MnfSerial),LotNumber=VALUES(LotNumber),ExpDate=VALUES(ExpDate),MnfDate=VALUES(MnfDate),InDate=VALUES(InDate),GrntStart=VALUES(GrntStart),
                                GrntExp=VALUES(GrntExp),CreateDate=VALUES(CreateDate),Location=VALUES(Location),Status=VALUES(Status),Notes=VALUES(Notes),DataSource=VALUES(DataSource),Transfered=VALUES(Transfered),Instance=VALUES(Instance),AbsEntry=VALUES(AbsEntry),ObjType=VALUES(ObjType),itemName=VALUES(itemName),LogInstanc=VALUES(LogInstanc),UpdateDate=VALUES(UpdateDate);";
                            await _repositoryBase.BatchAddAsync<store_osrn>(srnUpdSq, osrnList);

                        }
                    }
                }
                #endregion

                result.Code = 200;
                result.Message = "SAP同步成功;ERP同步成功";
            }catch(Exception ex)
            {
                result.Code = 202;
                result.Message = "SAP同步成功;ERP同步失败:" + ex.ToString();
            }
            return result;
        }

        public StockTransferApp(IRepositoryBase repositoryBase, Company oCompany, IAuth auth) : base(auth, repositoryBase)
        {
            company = oCompany;
        }

        public bool ExistNoDisNum(string itemcode)
        {
            bool result;
            string strSql = string.Format("SELECT ItemCode FROM OITM WHERE ManSerNum='Y' AND  ManBtchNum='N' AND ItemCode='{0}'", itemcode);
            var obj = _repositoryBase.Find<OITM>(strSql,null).FirstOrDefault();
            if (obj== null)
            { result = false; }
            else { result = true; }
            return result;
        }
    }
}
