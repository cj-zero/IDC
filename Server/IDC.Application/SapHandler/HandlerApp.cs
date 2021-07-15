using IDC.Application.Basics;
using IDC.Application.SapHandler.Request;
using IDC.Application.SSO;
using IDC.Infrastructure.Returned;
using IDC.Repository.Dapper;
using IDC.Repository.Entities.NsapBone;
using IDC.Repository.Entities.IDC;
using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.SapHandler
{
    public class HandlerApp : BaseApp
    {
        private readonly Company company;
        public HandlerApp(IRepositoryBase repositoryBase, IAuth auth, Company company) : base(auth, repositoryBase)
        {
            this.company = company;
        }
        /// <summary>
        /// 同步sap
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<Response> Rcvddetail(RcvddetailReq model)
        {
            StringBuilder errorMsg = new StringBuilder();
            int res = 0; int eCode = 0; string eMesg = string.Empty;string docNum = string.Empty;
            try
            {
                SAPbobsCOM.Documents dts = (SAPbobsCOM.Documents)company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oPurchaseDeliveryNotes);
                #region [添加主表信息]
                dts.CardCode = model.CardCode;
                dts.ContactPersonCode = int.Parse(model.CntctCode == "" ? "0" : model.CntctCode);
                dts.SalesPersonCode = int.Parse(model.SlpCode == "" ? "-1" : model.SlpCode);
                dts.NumAtCard = model.NumAtCard;
                dts.DocCurrency = model.DocCur;
                dts.DocDate = DateTime.Parse(model.DocDate);
                dts.DocDueDate = DateTime.Parse(model.DocDueDate);
                if (model.PartSupply == "true") { dts.PartialSupply = BoYesNoEnum.tYES; }
                else { dts.PartialSupply = BoYesNoEnum.tNO; }
                dts.Comments = model.Comments;
                dts.Address2 = model.Address2;      //收货方
                dts.Address = model.Address;        //收款方                    
                if (!string.IsNullOrEmpty(model.U_FPLB) && model.U_FPLB != "")
                {
                    dts.UserFields.Fields.Item("U_FPLB").Value = model.U_FPLB;
                }
                if (!string.IsNullOrEmpty(model.U_SL) && model.U_SL != "")
                {
                    dts.UserFields.Fields.Item("U_SL").Value = model.U_SL;
                }
                if (!string.IsNullOrEmpty(model.GroupNum))
                {
                    dts.PaymentGroupCode = int.Parse(model.GroupNum);   //付款条款
                }
                dts.Indicator = model.Indicator;    // 标识
                dts.FederalTaxID = model.LicTradNum;  //国税编号
                dts.Project = "";

                dts.PayToCode = model.PayToCode;
                dts.ShipToCode = model.ShipToCode;
                if (!string.IsNullOrEmpty(model.TrnspCode))
                {
                    dts.TransportationCode = Convert.ToInt32(model.TrnspCode);
                }
                if (!string.IsNullOrEmpty(model.OwnerCode))
                {
                    dts.DocumentsOwner = Convert.ToInt32(model.OwnerCode);
                }
                if (!string.IsNullOrEmpty(model.DocType))
                {
                    if (model.DocType == "I")
                        dts.DocType = BoDocumentTypes.dDocument_Items;
                    if (model.DocType == "S")
                        dts.DocType = BoDocumentTypes.dDocument_Service;
                }
                else { dts.DocType = BoDocumentTypes.dDocument_Items; }

                //if (!string.IsNullOrEmpty(model.CustomFields) && model.CustomFields != "{}")
                //{
                //    string[] filesName = model.CustomFields.Replace(",", "，").Replace("≮0≯", ",").Split(',');
                //    string[] filesValue = "".Split(',');
                //    for (int i = 0; i < filesName.Length; i++)
                //    {
                //        filesValue = filesName[i].Replace(":", "：").Replace("≮1≯", ":").Split(':');
                //        if (AidTool.IsExistCustomFields("OPDN", filesValue[0], sqlconn) && !string.IsNullOrEmpty(filesValue[1]))
                //        {
                //            dts.UserFields.Fields.Item(filesValue[0]).Value = filesValue[1];
                //        }
                //    }
                //}
                if (!string.IsNullOrEmpty(model.U_YGMD) && model.U_YGMD != "")
                {
                    dts.UserFields.Fields.Item("U_YGMD").Value = model.U_YGMD;
                }
                dts.PaymentMethod = model.PeyMethod;    //付款方式

                //errorMsg += string.Format("调用接口添加采购收货主数据[{0}]", jobID);
                #endregion

                #region [添加行明细]
                if (model.DocType == "I")
                {
                    foreach (var dln1 in model.billSalesDetails)
                    {
                        if (model.DocType == "I")
                        {
                            dts.Lines.ItemCode = dln1.ItemCode.Replace("&#92;", "■");
                            dts.Lines.ItemDescription = dln1.Dscription;
                            dts.Lines.Quantity = string.IsNullOrEmpty(dln1.Quantity) ? '1' : double.Parse(dln1.Quantity);
                            dts.Lines.WarehouseCode = model.WhsCode == "" ? "01" : model.WhsCode;
                        }
                        if (!string.IsNullOrEmpty(dln1.BaseEntry))
                        {
                            dts.Lines.BaseEntry = int.Parse(dln1.BaseEntry == "" ? "-1" : dln1.BaseEntry);
                            dts.Lines.BaseLine = int.Parse(dln1.BaseLine);
                            dts.Lines.BaseType = int.Parse(model.billBaseType == "" ? "-1" : model.billBaseType);
                        }
                        dts.Lines.UnitPrice = double.Parse(dln1.Price == "" ? "0" : dln1.Price);            //单价

                        if (!string.IsNullOrEmpty(dln1.U_PDXX))
                        {
                            dts.Lines.UserFields.Fields.Item("U_PDXX").Value = dln1.U_PDXX;
                        }
                        dts.Lines.VatGroup = "J0";
                        dts.Lines.Add();
                    }
                }
                else
                {
                    foreach (var oact in model.billSalesAcctCode)
                    {
                        if (!string.IsNullOrEmpty(oact.BaseEntry))
                        {
                            dts.Lines.BaseEntry = int.Parse(oact.BaseEntry == "" ? "-1" : oact.BaseEntry);
                            dts.Lines.BaseLine = int.Parse(oact.BaseLine);
                            dts.Lines.BaseType = int.Parse(model.billBaseType == "" ? "-1" : model.billBaseType);
                        }
                        dts.Lines.AccountCode = oact.AcctCode;
                        dts.Lines.ItemDescription = oact.Details;
                        dts.Lines.UnitPrice = double.Parse(oact.Price == "" ? "0" : oact.Price);            //单价
                        dts.Lines.VatGroup = "J0";
                        dts.Lines.Add();
                    }
                }
                //errorMsg += string.Format("调用接口添加采购收货行明细[{0}]", jobID);
                #endregion
                res = dts.Add();
                if (res != 0)
                {
                    company.GetLastError(out eCode, out eMesg);
                    errorMsg.Append(string.Format("添加采购收货时调接口发生异常[异常代码:{0},异常信息:{1}]", eCode, eMesg));
                   
                }
                else
                {
                    company.GetNewObjectCode(out docNum);
                    errorMsg.Append($"调用接口添加采购收货操作成功,ID[{docNum}]");
                }
            }
            catch (Exception e)
            {
                errorMsg.Append($"添加采购收货时调接口发生异常(eCode:{e})");
            }
            return new Response();
        }
        /// <summary>
        /// 同步ERP3.0
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<Response> RcddetailErp(RcvddetailReq model,string docNum) 
        {

            #region 添加主数据
            if (model.PartSupply == "true") { model.PartSupply = "Y"; } else { model.PartSupply = "N"; }
            if (model.DocCur == "") { model.DocCur = "RMB"; }
            //if (dtRowOPDN.Rows[0][3].ToString() == "") { model.DocRate = "1"; }
            //if (model.DocTotal.ToString() == "") { model.DocTotal = "0"; }
            if (model.OwnerCode == "") { model.OwnerCode = "-1"; }
            if (model.SlpCode == "") { model.SlpCode = "-1"; }
            var opdnsql = @$"INSERT INTO buy_opdn(sbo_id,DocEntry,DocNum,DocType,Printed,DocStatus,ObjType,
                        DocDate,DocDueDate,CardCode,CardName,Address,NumAtCard,VatSum,DiscPrcnt,DiscSum,DocCur,DocRate,DocTotal,
                        PaidToDate,GrosProfit,Comments,JrnlMemo,GroupNum,SlpCode,TrnspCode,PartSupply
                        CurSource,UpdateDate,CreateDate,TaxDate,TotalExpns,Address2,Indicator,ShipToCode,LicTradNum,
                        PeyMethod,Ref1,PayToCode,CntctCode,CtlAccount,SupplCode,OwnerCode,U_SL,U_FPLB,U_YGMD) VALUES(
                        @sbo_id,@DocEntry,@DocNum,@DocType,@Printed,@DocStatus,@ObjType,
                        @DocDate,@DocDueDate,@CardCode,@CardName,@Address,@NumAtCard,@VatSum,@DiscPrcnt,@DiscSum,@DocCur,@DocRate,@DocTotal,
                        @PaidToDate,@GrosProfit,@Comments,@JrnlMemo,@GroupNum,@SlpCode,@TrnspCode,@PartSupply
                        @CurSource,@UpdateDate,@CreateDate,@TaxDate,@TotalExpns,@Address2,@Indicator,@ShipToCode,@LicTradNum,
                        @PeyMethod,@Ref1,@PayToCode,@CntctCode,@CtlAccount,@SupplCode,@OwnerCode,@U_SL,@U_FPLB,@U_YGMD)";

            buy_opdn opdn = new buy_opdn {
                sbo_id = Define.Sbo_Id,
                DocEntry=int.Parse(docNum),
                DocNum= int.Parse(docNum),
            };
            #endregion
            #region 添加行数据

            if ((model.billSalesDetails != null && model.billSalesDetails.Count > 0) || (model.billSalesAcctCode != null && model.billSalesAcctCode.Count > 0))
            {
                var pdn1sql = @$"INSERT INTO buy_pdn1 (sbo_id,DocEntry,LineNum,TargetType,TrgetEntry,BaseRef,BaseType,BaseEntry,BaseLine,LineStatus,ItemCode,Dscription,
                                Quantity,Price,Currency,Rate,DiscPrcnt,LineTotal,TotalFrgn,WhsCode,SlpCode,GrossBuyPr,PriceBefDi,DocDate,VatPrcnt,VatGroup,PriceAfVAT,
                                StockPrice,OpenQty,OpenSum,AcctCode,OrderedQty,TrnsCode,PackQty,BaseCard,StockValue,GTotal,unitMsr,NumPerMsr,LineVat,INMPrice,VisOrder,GrssProfit,FinncPriod,ObjType,OpenCreQty) VALUES (
                                @sbo_id,@DocEntry,@LineNum,@TargetType,@TrgetEntry,@BaseRef,@BaseType,@BaseEntry,@BaseLine,@LineStatus,@ItemCode,@Dscription,
                                @Quantity,@Price,@Currency,@Rate,@DiscPrcnt,@LineTotal,@TotalFrgn,@WhsCode,@SlpCode,@GrossBuyPr,@PriceBefDi,@DocDate,@VatPrcnt,@VatGroup,@PriceAfVAT,
                                @StockPrice,@OpenQty,@OpenSum,@AcctCode,@OrderedQty,@TrnsCode,@PackQty,@BaseCard,@StockValue,@GTotal,@unitMsr,@NumPerMsr,@LineVat,@INMPrice,@VisOrder,@GrssProfit,@FinncPriod,@ObjType,@OpenCreQty)
                                ON Duplicate KEY UPDATE 
                                sbo_id=VALUES(@sbo_id),DocEntry=VALUES(DocEntry),LineNum=VALUES(LineNum),TargetType=VALUES(TargetType),TrgetEntry=VALUES(TrgetEntry),BaseRef=VALUES(BaseRef),BaseType=VALUES(BaseType),
                                BaseEntry=VALUES(BaseEntry),BaseLine=VALUES(BaseLine),LineStatus=VALUES(LineStatus),ItemCode=VALUES(ItemCode),Dscription=VALUES(Dscription),
                                Quantity=VALUES(Quantity),Price=VALUES(Price),Currency=VALUES(Currency),Rate=VALUES(Rate),DiscPrcnt=VALUES(DiscPrcnt),LineTotal=VALUES(LineTotal),TotalFrgn=VALUES(TotalFrgn),
                                WhsCode=VALUES(WhsCode),SlpCode=VALUES(SlpCode),GrossBuyPr=VALUES(GrossBuyPr),PriceBefDi=VALUES(PriceBefDi),DocDate=VALUES(DocDate),VatPrcnt=VALUES(VatPrcnt),
                                VatGroup=VALUES(VatGroup),PriceAfVAT=VALUES(PriceAfVAT),StockPrice=VALUES(StockPrice),OpenQty=VALUES(OpenQty),OpenSum=VALUES(OpenSum),AcctCode=VALUES(AcctCode),OrderedQty=VALUES(OrderedQty),
                                TrnsCode=VALUES(TrnsCode),PackQty=VALUES(PackQty),BaseCard=VALUES(BaseCard),StockValue=VALUES(StockValue),GTotal=VALUES(GTotal),unitMsr=VALUES(unitMsr),
                                NumPerMsr=VALUES(NumPerMsr),LineVat=VALUES(LineVat),INMPrice=VALUES(INMPrice),VisOrder=VALUES(VisOrder),GrssProfit=VALUES(GrssProfit),FinncPriod=VALUES(FinncPriod),
                                ObjType=VALUES(ObjType),OpenCreQty=VALUES(OpenCreQty)";
            }
            #endregion
            return new Response();
        }
        /// <summary>
        /// 信息添加
        /// </summary>
        /// <returns></returns>
        public async Task<int> Add()
        {
            var loginUser = _auth.GetCurrentUser();
            var sql = $"insert into handler(Content,DataSources,Status,CreateTime) values('{loginUser.UserName}','{loginUser.SystemKey}','{0}','{DateTime.Now}')";
            var number = await _repositoryBase.AddAsync<Handler>(sql);
            return number.Number;
        }
        /// <summary>
        /// 信息修改
        /// </summary>
        /// <returns></returns>
        public async Task Update(int Number)
        {
            var loginUser = _auth.GetCurrentUser();
            var sql = $"update handler set status={1} where number={Number}";
            await _repositoryBase.UpDateAsync<Handler>(sql);
        }
    }
}
