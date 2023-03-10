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
    public partial class JDT1 
    {
        public JDT1()
        {
          this.Account= string.Empty;
          this.FCCurrency= string.Empty;
          this.DueDate= DateTime.Now;
          this.ShortName= string.Empty;
          this.ContraAct= string.Empty;
          this.LineMemo= string.Empty;
          this.Ref3Line= string.Empty;
          this.TransType= string.Empty;
          this.RefDate= DateTime.Now;
          this.Ref2Date= DateTime.Now;
          this.Ref1= string.Empty;
          this.Ref2= string.Empty;
          this.BaseRef= string.Empty;
          this.Project= string.Empty;
          this.TransCode= string.Empty;
          this.ProfitCode= string.Empty;
          this.TaxDate= DateTime.Now;
          this.MthDate= DateTime.Now;
          this.RelType= string.Empty;
          this.VatGroup= string.Empty;
          this.Indicator= string.Empty;
          this.AdjTran= string.Empty;
          this.RevSource= string.Empty;
          this.ObjType= string.Empty;
          this.VatDate= DateTime.Now;
          this.PaymentRef= string.Empty;
          this.VatLine= string.Empty;
          this.Closed= string.Empty;
          this.DebCred= string.Empty;
          this.StornoAcc= string.Empty;
          this.IsNet= string.Empty;
          this.DunWizBlck= string.Empty;
          this.DunDate= DateTime.Now;
          this.TaxPostAcc= string.Empty;
          this.StaCode= string.Empty;
          this.TaxCode= string.Empty;
          this.ValidFrom= DateTime.Now;
          this.LvlUpdDate= DateTime.Now;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.ValidFrom2= DateTime.Now;
          this.ValidFrom3= DateTime.Now;
          this.ValidFrom4= DateTime.Now;
          this.ValidFrom5= DateTime.Now;
          this.WTaxCode= string.Empty;
          this.WTLiable= string.Empty;
          this.WTLine= string.Empty;
          this.PayBlock= string.Empty;
          this.LicTradNum= string.Empty;
          this.MatchRef= string.Empty;
          this.Ordered= string.Empty;
          this.BPLName= string.Empty;
          this.VatRegNum= string.Empty;
          this.SLEDGERF= string.Empty;
          this.InitRef2= string.Empty;
          this.InitRef3Ln= string.Empty;
          this.ExpUUID= string.Empty;
          this.ExpOPType= string.Empty;
          this.MYFtype= string.Empty;
          this.DocType= string.Empty;
          this.DocSubType= string.Empty;
          this.CemCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Account { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Debit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Credit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SYSCred { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SYSDeb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FCDebit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FCCredit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FCCurrency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SourceID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SourceLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShortName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IntrnMatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExtrMatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ContraAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref3Line { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Ref2Date { get; set; }
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
        public int? CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProfitCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SystemRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? MthDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ToMthSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BatchNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FinncPriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? RelTransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RelLineID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RelType { get; set; }
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
        public decimal? BaseSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Indicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AdjTran { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? VatDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaymentRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SYSBaseSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MultMatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SYSVatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Closed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrossValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CheckAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LineType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DebCred { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SequenceNr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StornoAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BalDueDeb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BalDueCred { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BalFcDeb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BalFcCred { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BalScDeb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BalScCred { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsNet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DunWizBlck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DunnLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DunDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TaxType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxPostAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StaCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StaType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValidFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrossValFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LvlUpdDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MIEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MIVEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ClsInTP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CenVatCom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MatType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PstngType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValidFrom2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValidFrom3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValidFrom4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValidFrom5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EquVatRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EquVatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SYSEquSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SYSTVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTLiable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTApplied { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTAppliedS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTAppliedF { get; set; }
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
        public string LicTradNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InterimTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? DprId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MatchRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ordered { get; set; }
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
        public string VatRegNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SLEDGERF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InitRef2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InitRef3Ln { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpUUID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpOPType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? ExTransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DocArr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MYFtype { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
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
        public string DocSubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RmrkTmpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CemCode { get; set; }
    }
}