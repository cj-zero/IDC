﻿using System;
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
    public partial class OPDF 
    {
        public OPDF()
        {
          this.DocType= string.Empty;
          this.Canceled= string.Empty;
          this.Handwrtten= string.Empty;
          this.Printed= string.Empty;
          this.DocDate= DateTime.Now;
          this.DocDueDate= DateTime.Now;
          this.CardCode= string.Empty;
          this.CardName= string.Empty;
          this.Address= string.Empty;
          this.CashAcct= string.Empty;
          this.CheckAcct= string.Empty;
          this.TrsfrAcct= string.Empty;
          this.TrsfrDate= DateTime.Now;
          this.TrsfrRef= string.Empty;
          this.PayNoDoc= string.Empty;
          this.DocCurr= string.Empty;
          this.DiffCurr= string.Empty;
          this.Ref1= string.Empty;
          this.Ref2= string.Empty;
          this.CounterRef= string.Empty;
          this.Comments= string.Empty;
          this.JrnlMemo= string.Empty;
          this.ShowAtCard= string.Empty;
          this.SpiltTrans= string.Empty;
          this.CreateTran= string.Empty;
          this.ObjType= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.ApplyVAT= string.Empty;
          this.TaxDate= DateTime.Now;
          this.confirmed= string.Empty;
          this.ShowJDT= string.Empty;
          this.BankCode= string.Empty;
          this.BankAcct= string.Empty;
          this.DataSource= string.Empty;
          this.VatGroup= string.Empty;
          this.SpltCredLn= string.Empty;
          this.PrjCode= string.Empty;
          this.PaymentRef= string.Empty;
          this.Submitted= string.Empty;
          this.Status= string.Empty;
          this.PayMth= string.Empty;
          this.BankCountr= string.Empty;
          this.BoeAcc= string.Empty;
          this.BoeAgent= string.Empty;
          this.BoeStatus= string.Empty;
          this.WtCode= string.Empty;
          this.WtAccount= string.Empty;
          this.Proforma= string.Empty;
          this.BpAct= string.Empty;
          this.PIndicator= string.Empty;
          this.PaPriority= string.Empty;
          this.PayToCode= string.Empty;
          this.IsPaytoBnk= string.Empty;
          this.PBnkCnt= string.Empty;
          this.PBnkCode= string.Empty;
          this.PBnkAccnt= string.Empty;
          this.PBnkBranch= string.Empty;
          this.WizDunBlck= string.Empty;
          this.VersionNum= string.Empty;
          this.VatDate= DateTime.Now;
          this.TransCode= string.Empty;
          this.PaymType= string.Empty;
          this.CancelDate= DateTime.Now;
          this.ChallanNo= string.Empty;
          this.ChallanBak= string.Empty;
          this.ChallanDat= DateTime.Now;
          this.WddStatus= string.Empty;
          this.BcgVatGrp= string.Empty;
          this.SeriesStr= string.Empty;
          this.SubStr= string.Empty;
          this.BSRCode= string.Empty;
          this.BuildDesc= string.Empty;
          this.ResidenNum= string.Empty;
          this.OperatCode= string.Empty;
          this.FreeText1= string.Empty;
          this.FreeText2= string.Empty;
          this.FreeText3= string.Empty;
          this.ShowDocNo= string.Empty;
          this.MIType= string.Empty;
          this.SupplCode= string.Empty;
          this.BPLName= string.Empty;
          this.VATRegNum= string.Empty;
          this.BPLCentPmt= string.Empty;
          this.SEPADate= DateTime.Now;
          this.TDSType= string.Empty;
          this.DrNo= string.Empty;
          this.PmntWTCert= string.Empty;
          this.EnPBnkAcct= string.Empty;
          this.EncryptIV= string.Empty;
          this.DPPStatus= string.Empty;
          this.PriceMode= string.Empty;
          this.U_XSDB= string.Empty;
          this.U_XSBM= string.Empty;
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
        public string Canceled { get; set; }
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
        public decimal? DdctPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DdctSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DdctSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CashAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CashSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CashSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CreditSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CredSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CheckSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CheckSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrsfrAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TrsfrSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TrsfrSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TrsfrDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrsfrRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayNoDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NoDocSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NoDocSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DiffCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SysRate { get; set; }
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
        public string CounterRef { get; set; }
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
        public short? DocTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowAtCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpiltTrans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreateTran { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Flags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CntctCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DdctSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CashSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CredSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CheckSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TrsfrSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NoDocSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotalSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StornoRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApplyVAT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string confirmed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowJDT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGroup { get; set; }
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
        public decimal? VatSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FinncPriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Dcount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DcntSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DcntSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DcntSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpltCredLn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrjCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaymentRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Submitted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayMth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCountr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FreightSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FreigtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FreigtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BoeNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BoeSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BoeSumFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BoeSumSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeAgent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WtCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtSumFrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtSumSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WtAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtBaseAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Proforma { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BoeAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PIndicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaPriority { get; set; }
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
        public string PBnkCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PBnkCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PBnkAccnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PBnkBranch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WizDunBlck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtBaseSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtBaseSumF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtBaseSumS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UndOvDiff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UndOvDiffS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BankActKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VersionNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? VatDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaymType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TfrRealAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CancelDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenBalFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenBalSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgTaxSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgTaxSumF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgTaxSumS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TpwID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChallanNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChallanBak { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ChallanDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WddStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BcgVatGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgVatPcnt { get; set; }
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
        public string BSRCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LocCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTOnhldPst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
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
        public string OperatCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UndOvDiffF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MIEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeText1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeText2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeText3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowDocNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TDSInterst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TDSCharges { get; set; }
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
        public string MIType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SupplCode { get; set; }
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
        public string BPLCentPmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DraftKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TDSFee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MinHeadCL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SEPADate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OwnerCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AgrNo { get; set; }
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
        public string TDSType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DrNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PmntWTCert { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnPBnkAcct { get; set; }
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
        public string PriceMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_XSDB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_XSBM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? U_XSDD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_DKJE { get; set; }
    }
}