using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using IDC.Repository.Dapper;

namespace IDC.Repository.Entities.Sap
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("SapDbContext", "SapReadDbContext", DatabaseType.SqlServer)]
    public partial class OSFC 
    {
        public OSFC()
        {
          this.DocType= string.Empty;
          this.CANCELED= string.Empty;
          this.Handwrtten= string.Empty;
          this.Printed= string.Empty;
          this.DocStatus= string.Empty;
          this.InvntSttus= string.Empty;
          this.Transfered= string.Empty;
          this.ObjType= string.Empty;
          this.DocDate= DateTime.Now;
          this.DocDueDate= DateTime.Now;
          this.CardCode= string.Empty;
          this.CardName= string.Empty;
          this.Address= string.Empty;
          this.NumAtCard= string.Empty;
          this.DocCur= string.Empty;
          this.Ref1= string.Empty;
          this.Ref2= string.Empty;
          this.Comments= string.Empty;
          this.JrnlMemo= string.Empty;
          this.PartSupply= string.Empty;
          this.Confirmed= string.Empty;
          this.CreateTran= string.Empty;
          this.SummryType= string.Empty;
          this.UpdInvnt= string.Empty;
          this.UpdCardBal= string.Empty;
          this.InvntDirec= string.Empty;
          this.ShowSCN= string.Empty;
          this.FatherCard= string.Empty;
          this.CurSource= string.Empty;
          this.FatherType= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.IsICT= string.Empty;
          this.CreateDate= DateTime.Now;
          this.TaxDate= DateTime.Now;
          this.Filler= string.Empty;
          this.DataSource= string.Empty;
          this.StampNum= string.Empty;
          this.isCrin= string.Empty;
          this.selfInv= string.Empty;
          this.WddStatus= string.Empty;
          this.Address2= string.Empty;
          this.Exported= string.Empty;
          this.Indicator= string.Empty;
          this.NetProc= string.Empty;
          this.ShipToCode= string.Empty;
          this.LicTradNum= string.Empty;
          this.PaymentRef= string.Empty;
          this.CheckDigit= string.Empty;
          this.Box1099= string.Empty;
          this.submitted= string.Empty;
          this.PoPrss= string.Empty;
          this.Rounding= string.Empty;
          this.RevisionPo= string.Empty;
          this.ReqDate= DateTime.Now;
          this.CancelDate= DateTime.Now;
          this.PickStatus= string.Empty;
          this.Pick= string.Empty;
          this.BlockDunn= string.Empty;
          this.PeyMethod= string.Empty;
          this.PayBlock= string.Empty;
          this.MaxDscn= string.Empty;
          this.Reserve= string.Empty;
          this.CntrlBnk= string.Empty;
          this.PickRmrk= string.Empty;
          this.ISRCodLine= string.Empty;
          this.Project= string.Empty;
          this.DeferrTax= string.Empty;
          this.LetterNum= string.Empty;
          this.FromDate= DateTime.Now;
          this.ToDate= DateTime.Now;
          this.BoeReserev= string.Empty;
          this.AgentCode= string.Empty;
          this.VATFirst= string.Empty;
          this.VatDate= DateTime.Now;
          this.CorrExt= string.Empty;
          this.CEECFlag= string.Empty;
          this.CtlAccount= string.Empty;
          this.BPLName= string.Empty;
          this.VATRegNum= string.Empty;
          this.TxInvRptNo= string.Empty;
          this.TxInvRptDt= DateTime.Now;
          this.KVVATCode= string.Empty;
          this.WTDetails= string.Empty;
          this.SumRptDate= DateTime.Now;
          this.PIndicator= string.Empty;
          this.ManualNum= string.Empty;
          this.UseShpdGd= string.Empty;
          this.DocSubType= string.Empty;
          this.DpmStatus= string.Empty;
          this.DpmDrawn= string.Empty;
          this.FolioPref= string.Empty;
          this.Header= string.Empty;
          this.Footer= string.Empty;
          this.Posted= string.Empty;
          this.BPChCode= string.Empty;
          this.PayToCode= string.Empty;
          this.IsPaytoBnk= string.Empty;
          this.BnkCntry= string.Empty;
          this.BankCode= string.Empty;
          this.BnkAccount= string.Empty;
          this.BnkBranch= string.Empty;
          this.isIns= string.Empty;
          this.TrackNo= string.Empty;
          this.VersionNum= string.Empty;
          this.BPNameOW= string.Empty;
          this.BillToOW= string.Empty;
          this.ShipToOW= string.Empty;
          this.RetInvoice= string.Empty;
          this.ClsDate= DateTime.Now;
          this.MInvDate= DateTime.Now;
          this.SeriesStr= string.Empty;
          this.SubStr= string.Empty;
          this.Model= string.Empty;
          this.LastPmnTyp= string.Empty;
          this.UseCorrVat= string.Empty;
          this.BlkCredMmo= string.Empty;
          this.OpenForLaC= string.Empty;
          this.Excised= string.Empty;
          this.ExcRefDate= DateTime.Now;
          this.ExcRmvTime= string.Empty;
          this.CertNum= string.Empty;
          this.DutyStatus= string.Empty;
          this.AutoCrtFlw= string.Empty;
          this.FlwRefDate= DateTime.Now;
          this.FlwRefNum= string.Empty;
          this.InsurOp347= string.Empty;
          this.IgnRelDoc= string.Empty;
          this.BuildDesc= string.Empty;
          this.ResidenNum= string.Empty;
          this.SSIExmpt= string.Empty;
          this.PQTGrpHW= string.Empty;
          this.ReopOriDoc= string.Empty;
          this.ReopManCls= string.Empty;
          this.DocManClsd= string.Empty;
          this.SpecDate= DateTime.Now;
          this.Ordered= string.Empty;
          this.NTSApprov= string.Empty;
          this.NTSeTaxNo= string.Empty;
          this.NTSApprNo= string.Empty;
          this.PayDuMonth= string.Empty;
          this.SignMsg= string.Empty;
          this.SignDigest= string.Empty;
          this.CertifNum= string.Empty;
          this.EDocGenTyp= string.Empty;
          this.EDocNum= string.Empty;
          this.OnlineQuo= string.Empty;
          this.POSEqNum= string.Empty;
          this.POSManufSN= string.Empty;
          this.EDocStatus= string.Empty;
          this.EDocCntnt= string.Empty;
          this.EDocProces= string.Empty;
          this.EDocErrCod= string.Empty;
          this.EDocErrMsg= string.Empty;
          this.EDocCancel= string.Empty;
          this.EDocTest= string.Empty;
          this.EDocPrefix= string.Empty;
          this.DpmAsDscnt= string.Empty;
          this.Attachment= string.Empty;
          this.SupplCode= string.Empty;
          this.GTSRlvnt= string.Empty;
          this.SrvTaxRule= string.Empty;
          this.Supplier= string.Empty;
          this.ToWhsCode= string.Empty;
          this.AssetDate= DateTime.Now;
          this.Requester= string.Empty;
          this.ReqName= string.Empty;
          this.Email= string.Empty;
          this.Notify= string.Empty;
          this.OriginType= string.Empty;
          this.IsReuseNum= string.Empty;
          this.IsReuseNFN= string.Empty;
          this.DocDlvry= string.Empty;
          this.IsAlt= string.Empty;
          this.AuthCode= string.Empty;
          this.StDlvDate= DateTime.Now;
          this.EndDlvDate= DateTime.Now;
          this.VclPlate= string.Empty;
          this.ElCoStatus= string.Empty;
          this.AtDocType= string.Empty;
          this.ElCoMsg= string.Empty;
          this.PrintSEPA= string.Empty;
          this.FiscDocNum= string.Empty;
          this.ExcDocDate= DateTime.Now;
          this.PTICode= string.Empty;
          this.Letter= string.Empty;
          this.ToBinCode= string.Empty;
          this.PriceMode= string.Empty;
          this.PoDropPrss= string.Empty;
          this.PermitNo= string.Empty;
          this.MYFtype= string.Empty;
          this.DocTaxID= string.Empty;
          this.DateReport= DateTime.Now;
          this.RepSection= string.Empty;
          this.ExclTaxRep= string.Empty;
          this.DmpTransID= string.Empty;
          this.ECommerBP= string.Empty;
          this.EComerGSTN= string.Empty;
          this.Revision= string.Empty;
          this.RevRefNo= string.Empty;
          this.RevRefDate= DateTime.Now;
          this.RevCreRefN= string.Empty;
          this.RevCreRefD= DateTime.Now;
          this.TaxInvNo= string.Empty;
          this.FrmBpDate= DateTime.Now;
          this.GSTTranTyp= string.Empty;
          this.ComTrade= string.Empty;
          this.UseBilAddr= string.Empty;
          this.ComTradeRt= string.Empty;
          this.SplitPmnt= string.Empty;
          this.SelfPosted= string.Empty;
          this.EnBnkAcct= string.Empty;
          this.EncryptIV= string.Empty;
          this.DPPStatus= string.Empty;
          this.EWBGenType= string.Empty;
          this.SAPPassprt= string.Empty;
          this.EDocType= string.Empty;
          this.U_CPH= string.Empty;
          this.U_YSQX= string.Empty;
          this.U_THYY= string.Empty;
          this.U_SL= string.Empty;
          this.U_YGMD= string.Empty;
          this.U_OC_CN= string.Empty;
          this.U_OC_AD= string.Empty;
          this.U_OC_NA= string.Empty;
          this.U_OC_TE= string.Empty;
          this.U_PRX_SID= string.Empty;
          this.U_PRX_TkNo= string.Empty;
          this.U_PRX_SRVR= string.Empty;
          this.U_ShipName= string.Empty;
          this.U_SMAZ= string.Empty;
          this.U_job_id= string.Empty;
          this.U_FPLB= string.Empty;
          this.U_SCBM= string.Empty;
          this.U_YWY= string.Empty;
          this.U_KHDM= string.Empty;
          this.U_New_ORDRID= string.Empty;
          this.U_TSYQ= string.Empty;
          this.U_EshopNo= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CANCELED { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Handwrtten { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Printed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvntSttus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NumAtCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DiscPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DiscSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DiscSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocCur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrosProfit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrosProfFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JrnlMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ReceiptNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GroupNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DocTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SlpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TrnspCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PartSupply { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Confirmed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GrossBase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ImportEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreateTran { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SummryType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UpdInvnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UpdCardBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Instance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Flags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvntDirec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CntctCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowSCN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FatherCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SysRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CurSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DiscSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotalSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FatherType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrosProfSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsICT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Volume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? VolUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Weight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? WeightUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Filler { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StampNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string isCrin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FinncPriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string selfInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPaid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPaidFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPaidSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WddStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? draftKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalExpns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalExpFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalExpSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DunnLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Exported { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StationID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Indicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NetProc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AqcsTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AqcsTaxFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AqcsTaxSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CashDiscPr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CashDiscnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CashDiscFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CashDiscSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShipToCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LicTradNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaymentRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RoundDif { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RoundDifFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RoundDifSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckDigit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Form1099 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Box1099 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string submitted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PoPrss { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Rounding { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevisionPo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Segment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ReqDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CancelDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PickStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Pick { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockDunn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PeyMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBlock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PayBlckRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MaxDscn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Reserve { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Max1099 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntrlBnk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PickRmrk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISRCodLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpAppl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpApplFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpApplSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeferrTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LetterNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FromDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTApplied { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTAppliedF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeReserev { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AgentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTAppliedS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EquVatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EquVatSumF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EquVatSumS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Installmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VATFirst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NnSbAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NnSbAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NbSbAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExepAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExepAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExepAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? VatDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CorrExt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CorrInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NCorrInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CEECFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CtlAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? BPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPLName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VATRegNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TxInvRptNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TxInvRptDt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KVVATCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? SumAbsId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SumRptDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PIndicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManualNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseShpdGd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseVtAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseVtAtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseVtAtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NnSbVAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NnSbVAtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NbSbVAtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExptVAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExptVAtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExptVAtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LYPmtAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LYPmtAtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LYPmtAtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpAnSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpAnSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpAnFrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocSubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpmStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpmDrawn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidSumFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidSumSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FolioPref { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FolioNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmAppl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmApplFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmApplSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LPgFolioN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Header { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Footer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Posted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OwnerCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPChCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BPChCntc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayToCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsPaytoBnk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BnkCntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BnkAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BnkBranch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string isIns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrackNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VersionNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LangCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPNameOW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BillToOW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShipToOW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RetInvoice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ClsDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MInvNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? MInvDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SeqCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Serial { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeriesStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Model { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExpFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExpSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExAp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExApF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExApS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LastPmnTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LndCstNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseCorrVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlkCredMmo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpenForLaC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Excised { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ExcRefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExcRmvTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SrvGpPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DepositNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CertNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DutyStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoCrtFlw { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FlwRefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FlwRefNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VatJENum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmVatFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmVatSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmAppVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmAppVatF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmAppVatS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InsurOp347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IgnRelDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BuildDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResidenNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Checker { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Payee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CopyNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SSIExmpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PQTGrpSer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PQTGrpNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PQTGrpHW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReopOriDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReopManCls { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocManClsd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ClosingOpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SpecDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ordered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NTSApprov { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? NTSWebSite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NTSeTaxNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NTSApprNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayDuMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ExtraMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ExtraDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CdcOffset { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SignMsg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SignDigest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CertifNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? KeyVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocGenTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ESeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EDocExpFrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OnlineQuo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string POSEqNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string POSManufSN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? POSCashN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocCntnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocProces { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocErrCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocErrMsg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocCancel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocTest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocPrefix { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CUP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CIG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpmAsDscnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attachment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SupplCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GTSRlvnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseDisc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseDiscSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseDiscFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseDiscPr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CreateTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UpdateTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrvTaxRule { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AnnInvDecR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Supplier { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Releaser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Receiver { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToWhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? AssetDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Requester { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReqName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Branch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Department { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Notify { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ReqType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OriginType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsReuseNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsReuseNFN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocDlvry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidDpm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidDpmF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidDpmS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EnvTypeNFe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AgrNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsAlt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AltBaseTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AltBaseEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AuthCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StDlvDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StDlvTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EndDlvDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EndDlvTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VclPlate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ElCoStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AtDocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ElCoMsg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrintSEPA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FreeChrg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FreeChrgFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FreeChrgSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NfeValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FiscDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RelatedTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RelatedEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CCDEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NfePrntFo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ZrdAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? POSRcptNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FoCTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FoCTaxFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FoCTaxSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TpCusPres { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ExcDocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FoCFrght { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FoCFrghtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FoCFrghtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? InterimTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PTICode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Letter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FolNumFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FolNumTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FolSeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SplitTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SplitTaxFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SplitTaxSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToBinCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriceMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PoDropPrss { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PermitNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MYFtype { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocTaxID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateReport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepSection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExclTaxRep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PosCashReg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DmpTransID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ECommerBP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EComerGSTN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Revision { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevRefNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RevRefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevCreRefN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RevCreRefD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxInvNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FrmBpDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GSTTranTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ComTrade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseBilAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? IssReason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ComTradeRt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SplitPmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? SOIWizId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SelfPosted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnBnkAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPPStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EWBGenType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SAPPassprt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CtActTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CtActTaxFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CtActTaxSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_CPH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_YSQX { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_THYY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_SL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_YF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_KDF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_BZF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_YCF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_YGMD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_OC_CN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_OC_AD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_OC_NA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_OC_TE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_SID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_TkNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_SRVR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ShipName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_SMAZ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_job_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_FPLB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_CCF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_THF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_SCBM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_YWY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_KHDM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_New_ORDRID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_TSYQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_EshopNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_DocRCTAmount { get; set; }
    }
}