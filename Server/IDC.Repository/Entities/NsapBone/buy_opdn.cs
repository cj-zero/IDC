using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDC.Repository.Entities.NsapBone
{
    /// <summary>
    /// 采购收料单
    /// </summary>
    [ConnectionString("NsapBoneDbContext", "NsapBoneReadDbContext")]
    public partial class buy_opdn 
    {
        public buy_opdn()
        {
          this.DocType= string.Empty;
          this.CANCELED= string.Empty;
          this.Handwrtten= string.Empty;
          this.Printed= string.Empty;
          this.DocStatus= string.Empty;
          this.InvntSttus= string.Empty;
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
          this.UpdateDate= DateTime.Now;
          this.IsICT= string.Empty;
          this.CreateDate= DateTime.Now;
          this.TaxDate= DateTime.Now;
          this.Address2= string.Empty;
          this.Exported= string.Empty;
          this.Indicator= string.Empty;
          this.ShipToCode= string.Empty;
          this.LicTradNum= string.Empty;
          this.PaymentRef= string.Empty;
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
          this.PickRmrk= string.Empty;
          this.Project= string.Empty;
          this.DeferrTax= string.Empty;
          this.CtlAccount= string.Empty;
          this.PIndicator= string.Empty;
          this.ManualNum= string.Empty;
          this.UseShpdGd= string.Empty;
          this.DpmDrawn= string.Empty;
          this.Posted= string.Empty;
          this.PayToCode= string.Empty;
          this.IsPaytoBnk= string.Empty;
          this.BnkCntry= string.Empty;
          this.BankCode= string.Empty;
          this.BnkAccount= string.Empty;
          this.BnkBranch= string.Empty;
          this.ClsDate= DateTime.Now;
          this.LastPmnTyp= string.Empty;
          this.UseCorrVat= string.Empty;
          this.OpenForLaC= string.Empty;
          this.ExcRefDate= DateTime.Now;
          this.ExcRmvTime= string.Empty;
          this.Ordered= string.Empty;
          this.PayDuMonth= string.Empty;
          this.CertifNum= string.Empty;
          this.OnlineQuo= string.Empty;
          this.POSEqNum= string.Empty;
          this.POSManufSN= string.Empty;
          this.DpmAsDscnt= string.Empty;
          this.SupplCode= string.Empty;
          this.GTSRlvnt= string.Empty;
          this.SrvTaxRule= string.Empty;
          this.Supplier= string.Empty;
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
          this.U_S_YWF= string.Empty;
          this.U_SMAZ= string.Empty;
          this.U_job_id= string.Empty;
          this.U_FPLB= string.Empty;
        }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Key]
        public int sbo_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Key]
        public int DocEntry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int DocNum { get; set; }
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
        public short? SlpCode { get; set; }
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
        public string CurSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime UpdateDate { get; set; }
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
        public short? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FinncPriod { get; set; }
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
        public string Exported { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Indicator { get; set; }
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
        public string PickRmrk { get; set; }
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
        public decimal? BaseAmnt { get; set; }
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
        public decimal? DpmAmnt { get; set; }
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
        public string Posted { get; set; }
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
        public System.DateTime? ClsDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SeqCode { get; set; }
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
        public string LastPmnTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseCorrVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpenForLaC { get; set; }
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
        public string Ordered { get; set; }
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
        public string CertifNum { get; set; }
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
        public string SrvTaxRule { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Supplier { get; set; }
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
        public decimal? U_ZJJE { get; set; }
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
        public string U_S_YWF { get; set; }
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
        public short? OwnerCode { get; set; }
    }
}