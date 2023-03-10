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
    public partial class RRR4 
    {
        public RRR4()
        {
          this.StcCode= string.Empty;
          this.StaCode= string.Empty;
          this.TaxAcct= string.Empty;
          this.ObjectType= string.Empty;
          this.TaxStatus= string.Empty;
          this.DeferrAcct= string.Empty;
          this.NonDdctAct= string.Empty;
          this.TaxInPrice= string.Empty;
          this.Exempt= string.Empty;
          this.TaxExpAct= string.Empty;
          this.InGrossRev= string.Empty;
          this.Unencumbrd= string.Empty;
          this.TaxOnRI= string.Empty;
          this.InFirstIns= string.Empty;
          this.TaxAmtSrc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? GroupNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExpnsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RelateType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StcCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StaCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? staType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxSumFrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxSumSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseSumFrg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseSumSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxStatus { get; set; }
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
        public string DeferrAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseSeq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DeductTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DdctTaxFrg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DdctTaxSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseAppld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseApldFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseApldSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NonDdctPrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NonDdctAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxInPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Exempt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxExpAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OnHoldTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OnHoldTaxF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OnHoldTaxS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InGrossRev { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxSumOrg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxSumOrgF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxSumOrgS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenTaxFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenTaxSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Unencumbrd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxOnRI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsChrgPrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsChrgTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsChrgSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsChrgFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InFirstIns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExtTaxRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExtTaxSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxAmtSrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExtTaxSumF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExtTaxSumS { get; set; }
    }
}