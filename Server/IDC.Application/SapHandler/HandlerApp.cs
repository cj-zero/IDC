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
using IDC.Repository.Entities.Sap;
using IDC.Infrastructure.AutoMapper;
using Dapper;
using IDC.Repository.Entities.NsapBase;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using NSAP.Entity.Sales;

namespace IDC.Application.SapHandler
{
    public class HandlerApp : BaseApp
    {
        private readonly Company company;
        public HandlerApp(IRepositoryBase repositoryBase, Company company, IAuth auth) : base(auth, repositoryBase)
        {
            this.company = company;
        }

        #region 采购收料
        /// <summary>
        /// 同步sap
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<Response> Rcvddetail(RcvddetailReq model)
        {
            Response result = new Response();
            StringBuilder errorMsg = new StringBuilder();
            int res = 0; int eCode = 0; string eMesg = string.Empty; string docNum = string.Empty;
            try
            {
                var oporSql = @$"select * from buy_opor where sbo_id= {Define.Sbo_Id} and DocEntry={model.PurchaseId}";
                var oporObj = await _repositoryBase.DetailAsync<buy_opor>(oporSql);

                SAPbobsCOM.Documents dts = (SAPbobsCOM.Documents)company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oPurchaseDeliveryNotes);
                #region [添加主表信息]
                dts.CardCode = model.CardCode;//客户代码
                dts.ContactPersonCode = (int)oporObj.CntctCode;
                dts.SalesPersonCode = (int)oporObj.SlpCode;//销售员
                //dts.NumAtCard = model.NumAtCard;
                //dts.DocCurrency = model.DocCur;
                dts.DocDate = DateTime.Now;
                dts.DocDueDate = DateTime.Now;
                if (model.PartSupply == "true") { dts.PartialSupply = BoYesNoEnum.tYES; }
                else { dts.PartialSupply = BoYesNoEnum.tNO; }
                dts.Comments = model.Comments;      //备注
                dts.Address2 = oporObj.Address2;      //收货方
                dts.Address = oporObj.Address;        //收款方                    
                if (!string.IsNullOrEmpty(oporObj.U_FPLB) && oporObj.U_FPLB != "")
                {
                    dts.UserFields.Fields.Item("U_FPLB").Value = oporObj.U_FPLB;
                }
                if (!string.IsNullOrEmpty(oporObj.U_SL) && oporObj.U_SL != "")
                {
                    dts.UserFields.Fields.Item("U_SL").Value = oporObj.U_SL;
                }
                if (!string.IsNullOrEmpty(oporObj.GroupNum.ToString()))
                {
                    dts.PaymentGroupCode = int.Parse(oporObj.GroupNum.ToString());   //付款条款
                }
                dts.Indicator = oporObj.Indicator;    // 标识
                dts.FederalTaxID = oporObj.LicTradNum;  //国税编号
                dts.Project = "";

                dts.PayToCode = oporObj.PayToCode;//支付代码
                dts.ShipToCode = oporObj.ShipToCode;//购物代码
                if (!string.IsNullOrEmpty(oporObj.TrnspCode.ToString()))
                {
                    dts.TransportationCode = Convert.ToInt32(oporObj.TrnspCode);
                }
                if (!string.IsNullOrEmpty(oporObj.OwnerCode.ToString()))
                {
                    dts.DocumentsOwner = Convert.ToInt32(oporObj.OwnerCode);
                }
                if (!string.IsNullOrEmpty(oporObj.DocType))
                {
                    if (oporObj.DocType == "I")
                        dts.DocType = BoDocumentTypes.dDocument_Items;
                    if (oporObj.DocType == "S")
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
                if (!string.IsNullOrEmpty(oporObj.U_YGMD) && oporObj.U_YGMD != "")
                {
                    dts.UserFields.Fields.Item("U_YGMD").Value = oporObj.U_YGMD;
                }
                dts.PaymentMethod = oporObj.PeyMethod;    //付款方式

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
                        if (dln1.IsSerialNumber)
                        {
                            int i = 0;
                            foreach (var item in dln1.SerialNumbers)
                            {
                                if (item.SystemSerialNumber != null) dts.Lines.SerialNumbers.SystemSerialNumber = (int)item.SystemSerialNumber;
                                dts.Lines.SerialNumbers.ManufacturerSerialNumber = item.ManufacturerSerialNumber;
                                dts.Lines.SerialNumbers.InternalSerialNumber = item.InternalSerialNumber;
                                dts.Lines.SerialNumbers.SetCurrentLine(i);
                                dts.Lines.SerialNumbers.Add();
                                i++;
                            }
                        }
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
                    result.Code = 500;
                    errorMsg.Append(string.Format("添加采购收货时调接口发生异常[异常代码:{0},异常信息:{1}]", eCode, eMesg));
                    result.Message = errorMsg.ToString();

                }
                else
                {
                    company.GetNewObjectCode(out docNum);
                    errorMsg.Append($"调用接口添加采购收货操作成功,ID[{docNum}]");
                    await RcddetailErp(docNum, model);
                    result.Code = 200;
                    result.Message = errorMsg.ToString();
                }
            }
            catch (Exception e)
            {
                errorMsg.Append($"添加采购收货时调接口发生异常(eCode:{e})");
                result.Code = 500;
                result.Message = errorMsg.ToString();
            }
            return result;
        }
        /// <summary>
        /// 同步ERP3.0
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task RcddetailErp(string docNum, RcvddetailReq model)
        {
            #region 添加主数据
            var opdnsql = @$"INSERT INTO buy_opdn(sbo_id,DocEntry,DocNum,DocType,Printed,DocStatus,ObjType,
                        DocDate,DocDueDate,CardCode,CardName,Address,NumAtCard,VatSum,DiscPrcnt,DiscSum,DocCur,DocRate,DocTotal,
                        PaidToDate,GrosProfit,Comments,JrnlMemo,GroupNum,SlpCode,TrnspCode,PartSupply,
                        CurSource,UpdateDate,CreateDate,TaxDate,TotalExpns,Address2,Indicator,ShipToCode,LicTradNum,
                        PeyMethod,Ref1,PayToCode,CntctCode,CtlAccount,SupplCode,OwnerCode,U_SL,U_FPLB,U_YGMD) VALUES(
                        @sbo_id,@DocEntry,@DocNum,@DocType,@Printed,@DocStatus,@ObjType,
                        @DocDate,@DocDueDate,@CardCode,@CardName,@Address,@NumAtCard,@VatSum,@DiscPrcnt,@DiscSum,@DocCur,@DocRate,@DocTotal,
                        @PaidToDate,@GrosProfit,@Comments,@JrnlMemo,@GroupNum,@SlpCode,@TrnspCode,@PartSupply,
                        @CurSource,@UpdateDate,@CreateDate,@TaxDate,@TotalExpns,@Address2,@Indicator,@ShipToCode,@LicTradNum,
                        @PeyMethod,@Ref1,@PayToCode,@CntctCode,@CtlAccount,@SupplCode,@OwnerCode,@U_SL,@U_FPLB,@U_YGMD)";
            var selopdnsql = @$"select * from OPDN where DocEntry={docNum}";
            var opdnObj = (await _repositoryBase.GetAsync<OPDN>(selopdnsql)).FirstOrDefault();
            buy_opdn opdn = opdnObj.MapTo<buy_opdn>();
            if (opdn.PartSupply == "true") { opdn.PartSupply = "Y"; } else { opdn.PartSupply = "N"; }
            if (opdn.DocCur == "") { opdn.DocCur = "RMB"; }
            //if (dtRowOPDN.Rows[0][3].ToString() == "") { model.DocRate = "1"; }
            if (opdn.DocTotal.ToString() == "") { opdn.DocTotal = 0; }
            if (string.IsNullOrWhiteSpace(opdn.OwnerCode.ToString())) { opdn.OwnerCode = -1; }
            if (string.IsNullOrWhiteSpace(opdn.SlpCode.ToString())) { opdn.SlpCode = -1; }
            opdn.sbo_id = Define.Sbo_Id;
            await _repositoryBase.AddAsync<buy_opdn>(opdnsql, opdn);
            #endregion
            #region 添加行数据
            var pdn1sql = @$"INSERT INTO buy_pdn1 (sbo_id,DocEntry,LineNum,TargetType,TrgetEntry,BaseRef,BaseType,BaseEntry,BaseLine,LineStatus,ItemCode,Dscription,
                                Quantity,Price,Currency,Rate,DiscPrcnt,LineTotal,TotalFrgn,WhsCode,SlpCode,GrossBuyPr,PriceBefDi,DocDate,VatPrcnt,VatGroup,PriceAfVAT,
                                StockPrice,OpenQty,OpenSum,AcctCode,OrderedQty,TrnsCode,PackQty,BaseCard,StockValue,GTotal,unitMsr,NumPerMsr,LineVat,INMPrice,VisOrder,GrssProfit,FinncPriod,ObjType,OpenCreQty) VALUES (
                                @sbo_id,@DocEntry,@LineNum,@TargetType,@TrgetEntry,@BaseRef,@BaseType,@BaseEntry,@BaseLine,@LineStatus,@ItemCode,@Dscription,
                                @Quantity,@Price,@Currency,@Rate,@DiscPrcnt,@LineTotal,@TotalFrgn,@WhsCode,@SlpCode,@GrossBuyPr,@PriceBefDi,@DocDate,@VatPrcnt,@VatGroup,@PriceAfVAT,
                                @StockPrice,@OpenQty,@OpenSum,@AcctCode,@OrderedQty,@TrnsCode,@PackQty,@BaseCard,@StockValue,@GTotal,@unitMsr,@NumPerMsr,@LineVat,@INMPrice,@VisOrder,@GrssProfit,@FinncPriod,@ObjType,@OpenCreQty)
                                ";
            var pdn1Obj = await _repositoryBase.GetAsync<PDN1>(@$"select * from PDN1 where DocEntry={docNum}");
            var pdn1s = pdn1Obj.MapToList<buy_pdn1>();
            pdn1s.ForEach(p => p.sbo_id = Define.Sbo_Id);
            //opdn.sbo_id = Define.Sbo_Id;
            foreach (var item in pdn1s)
            {
                await _repositoryBase.AddAsync<buy_pdn1>(pdn1sql, item);
            }
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("itemCodes", pdn1s.Select(p => p.ItemCode).ToArray());
            parameters.Add("whsCodes", pdn1s.Select(p => p.WhsCode).ToArray());
            var oitwList = await _repositoryBase.GetAsync<OITW>($@"select ItemCode, IsCommited,OnHand,OnOrder from OITW where ItemCode in (@itemCodes) and WhsCode in(@whsCodes)", parameters);
            var oitws = oitwList.MapToList<OITW>();
            Dictionary<string, object> storeoitws = new Dictionary<string, object>();
            foreach (var item in oitwList)
            {
                var WhsCode = pdn1s.Where(o => o.ItemCode.Equals(item.ItemCode)).FirstOrDefault().WhsCode;

                storeoitws.TryAdd(@$"update store_oitw set OnHand={item.OnHand},IsCommited={item.IsCommited},OnOrder={item.OnOrder} where ItemCode={item.ItemCode} and WhsCode={WhsCode}", null);
            }
            var oitmList = await _repositoryBase.GetAsync<OITM>($@"select ItemCode, IsCommited, OnHand, OnOrder, LastPurCur, LastPurPrc, LastPurDat, UpdateDate from OITM where ItemCode in (@itemCodes)", parameters);
            var oitms = oitmList.MapToList<OITM>();
            foreach (var item in oitmList)
            {
                storeoitws.TryAdd($@"update store_oitm set OnHand={item.OnHand},IsCommited={item.IsCommited},OnOrder={item.OnOrder}, 
                            LastPurDat = {item.LastPurDat},LastPurPrc = {item.LastPurPrc},LastPurCur = {item.LastPurCur}, UpdateDate = {item.UpdateDate} where ItemCode ={item.ItemCode} ", null);
            }
            await _repositoryBase.ExecuteTransactionAsync<store_oitw>(storeoitws);
            #endregion
            #region 序列号
            var oitlsql = @$"select * from oitl where docentry={docNum} and doctype={20}";
            var oitls = await _repositoryBase.GetAsync<OITL>(oitlsql);
            if (oitls != null && oitls.Count() > 0)
            {
                var itl1sql = @$"select a.* from itl1 a  left join oitl  b on a.LogEntry=b.LogEntry and a.ItemCode =b.ItemCode where b.docentry={docNum} and b.doctype={20}";
                var itl1s = await _repositoryBase.GetAsync<ITL1>(itl1sql);
                var osrnsql = @$"select a.* from osrn a left join ITL1 b on a.SysNumber=b.SysNumber and a.ItemCode=b.ItemCode left join OITL  c on b.LogEntry=c.LogEntry and b.ItemCode =c.ItemCode where c.docentry={docNum} and c.doctype={20}";
                var osrns = await _repositoryBase.GetAsync<OSRN>(osrnsql);
                var storeoitls = oitls.MapToList<store_oitl>();
                storeoitls.ForEach(s => s.sbo_id = Define.Sbo_Id);
                var storeitl1s = itl1s.MapToList<store_itl1>();
                storeitl1s.ForEach(s => s.sbo_id = Define.Sbo_Id);
                var storeosrns = osrns.MapToList<store_osrn>();
                storeosrns.ForEach(s => s.sbo_id = Define.Sbo_Id);
                string addoitlsql = @$"INSERT INTO store_oitl(LogEntry, TransId, ItemCode, ItemName, ManagedBy, DocEntry, 
                        DocLine, DocType, DocNum, BaseEntry, BaseLine, BaseType, ApplyEntry, ApplyLine, ApplyType, DocDate, CardCode, CardName, DocQty, StockQty, 
                        DefinedQty, StockEff, CreateDate, LocType, LocCode, AppDocNum, VersionNum, Transfered, Instance, SubLineNum, BSubLineNo, AppSubLine, ActBaseTp, 
                        ActBaseEnt, ActBaseLn, ActBasSubL, AllocateTp, AllocatEnt, AllocateLn, sbo_id) VALUES (@LogEntry, @TransId, @ItemCode, @ItemName, @ManagedBy, @DocEntry, 
                        @DocLine, @DocType, @DocNum, BaseEntry, @BaseLine, @BaseType, @ApplyEntry, @ApplyLine, @ApplyType, @DocDate, @CardCode, @CardName, @DocQty, @StockQty, 
                        @DefinedQty, @StockEff, @CreateDate, @LocType, @LocCode, @AppDocNum, @VersionNum, @Transfered, @Instance, @SubLineNum, @BSubLineNo, @AppSubLine, @ActBaseTp, 
                        @ActBaseEnt, @ActBaseLn, @ActBasSubL, @AllocateTp, @AllocatEnt, @AllocateLn, @sbo_id);";
                await _repositoryBase.BatchAddAsync<store_oitl>(addoitlsql, storeoitls);
                string additl1sql = @$"INSERT INTO store_itl1(LogEntry, ItemCode, SysNumber, Quantity, AllocQty, MdAbsEntry, 
                        ReleaseQty, PickedQty, sbo_id) VALUES (@LogEntry, @ItemCode, @SysNumber, @Quantity, @AllocQty, @MdAbsEntry, 
                        @ReleaseQty, @PickedQty, @sbo_id);";
                await _repositoryBase.BatchAddAsync<store_itl1>(additl1sql, storeitl1s);
                string addosrnsql = @$"INSERT INTO store_osrn(sbo_id, ItemCode, SysNumber, DistNumber, MnfSerial, LotNumber, ExpDate, MnfDate, InDate, GrntStart, GrntExp, 
                        CreateDate, Location, Status, Notes, DataSource, UserSign, Transfered, Instance, AbsEntry, ObjType, 
                        itemName, LogInstanc, UserSign2, UpdateDate) VALUES (@sbo_id, @ItemCode, @SysNumber, @DistNumber,@MnfSerial, @LotNumber, @ExpDate, @MnfDate, @InDate, @GrntStart, @GrntExp, 
                        @CreateDate, @Location, @Status, @Notes, @DataSource, @UserSign, @Transfered, @Instance, @AbsEntry, @ObjType, 
                        @itemName, @LogInstanc, @UserSign2, @UpdateDate)";
                await _repositoryBase.BatchAddAsync<store_osrn>(addosrnsql, storeosrns);
            }
            #endregion
            #region 来料检验
            if (model.IQCDetails != null && model.IQCDetails.Count > 0)
            {

                foreach (var detail in model.IQCDetails)
                {
                    StringBuilder IQCsql = new StringBuilder();
                    IQCsql.AppendFormat(" INSERT INTO quality_iqc (Pur_no,ItemCode,ItemName,CardCode,CardName, ");
                    IQCsql.Append(" Income_dt,Inspect_dimension, Inspect_function, Inspect_appearance, Inspect_other, ");
                    IQCsql.Append(" Income_num, Sample_num, Defective_num, Inspect_result, Defective_desc, Check_remark, Item_pic, ProcessOperation, Accept_num, Reject_num) ");
                    IQCsql.Append(" VALUES(@Pur_no,@ItemCode,@ItemName,@CardCode,@CardName,");
                    IQCsql.Append(" @Income_dt,@Inspect_dimension, @Inspect_function, @Inspect_appearance, @Inspect_other, ");
                    IQCsql.Append(" @Income_num, @Sample_num, @Defective_num, @Inspect_result, @Defective_desc, @Check_remark, @Item_pic, @ProcessOperation, @Accept_num, @Reject_num) ");
                    await _repositoryBase.AddAsync<quality_iqc>(IQCsql.ToString(), detail);
                }
            }
            #endregion
        }

        #region hand
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
        #endregion
    }
    #endregion

}
