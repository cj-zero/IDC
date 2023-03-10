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
    public partial class RPC3 
    {
        public RPC3()
        {
          this.Comments= string.Empty;
          this.ObjType= string.Empty;
          this.DistrbMthd= string.Empty;
          this.TaxStatus= string.Empty;
          this.VatGroup= string.Empty;
          this.IsAcquistn= string.Empty;
          this.TaxCode= string.Empty;
          this.TaxType= string.Empty;
          this.WTLiable= string.Empty;
          this.BaseMethod= string.Empty;
          this.Stock= string.Empty;
          this.LstPchPrce= string.Empty;
          this.AnalysRpt= string.Empty;
          this.Status= string.Empty;
          this.FixCurr= string.Empty;
          this.OcrCode= string.Empty;
          this.TaxDistMtd= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.Project= string.Empty;
          this.VatGrpSrc= string.Empty;
          this.BaseTotal= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExpnsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalFrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalSumSy { get; set; }
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
        public decimal? PaidSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DistrbMthd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSumFrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DedVatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DedVatSumF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DedVatSumS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsAcquistn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTLiable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatApplied { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatAppldFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatAppldSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EquVatPer { get; set; }
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
        public decimal? LineVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineVatF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineVatS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Stock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LstPchPrce { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AnalysRpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseLnNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TrgType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TrgAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StDstr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StDstrSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StDstrFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FixCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatDscntPr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxDistMtd { get; set; }
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
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGrpSrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DrawnTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DrawnFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DrawnSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrsAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrsFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrsSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RetReqLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RetReqFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RetReqSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RRVatLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RRVatFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RRVatSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}