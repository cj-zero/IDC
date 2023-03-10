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
    public partial class OVTR 
    {
        public OVTR()
        {
          this.ReportName= string.Empty;
          this.RptLayout= string.Empty;
          this.FromDate= DateTime.Now;
          this.ToDate= DateTime.Now;
          this.TaxDate= string.Empty;
          this.RoundSum= string.Empty;
          this.Declration= string.Empty;
          this.FilterType= string.Empty;
          this.ExcludeWT= string.Empty;
          this.CustomerIn= string.Empty;
          this.VendorIn= string.Empty;
          this.Period= string.Empty;
          this.DocType= string.Empty;
          this.CreditMemo= string.Empty;
          this.DocTypeIn= string.Empty;
          this.AccountIn= string.Empty;
          this.DeferTaxIn= string.Empty;
          this.ApndxOOrP= string.Empty;
          this.DispOBCB= string.Empty;
          this.canceltn= string.Empty;
          this.HideNTrans= string.Empty;
          this.SeriesIn= string.Empty;
          this.UserCode= string.Empty;
          this.FromCardCo= string.Empty;
          this.ToCardCo= string.Empty;
          this.PostFrDate= DateTime.Now;
          this.PostToDate= DateTime.Now;
          this.DocFrDate= DateTime.Now;
          this.DocToDate= DateTime.Now;
          this.FromDoc1Nu= string.Empty;
          this.ToDoc1Nu= string.Empty;
          this.Serie1= string.Empty;
          this.Serie1CB= string.Empty;
          this.FromDoc2Nu= string.Empty;
          this.ToDoc2Nu= string.Empty;
          this.Serie2= string.Empty;
          this.Serie2CB= string.Empty;
          this.FromDoc3Nu= string.Empty;
          this.ToDoc3Nu= string.Empty;
          this.Serie3= string.Empty;
          this.Serie3CB= string.Empty;
          this.FromDoc4Nu= string.Empty;
          this.ToDoc4Nu= string.Empty;
          this.Serie4= string.Empty;
          this.Serie4CB= string.Empty;
          this.FromDoc5Nu= string.Empty;
          this.ToDoc5Nu= string.Empty;
          this.Serie5= string.Empty;
          this.Serie5CB= string.Empty;
          this.DateRBtn= string.Empty;
          this.MarkDocsIn= string.Empty;
          this.ExRate= string.Empty;
          this.ExRateDate= string.Empty;
          this.TrsPerioTp= string.Empty;
          this.DateType= string.Empty;
          this.IncServDoc= string.Empty;
          this.GrpBySCode= string.Empty;
          this.IncUnReDoc= string.Empty;
          this.DoYearSum= string.Empty;
          this.DefTaxOnly= string.Empty;
          this.ExcElDoc= string.Empty;
          this.QtrByMnt= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReportName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RptLayout { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FirstPrint { get; set; }
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
        public string TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RoundSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Declration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FilterType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExcludeWT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CustomerIn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VendorIn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Period { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Quarter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Year { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreditMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocTypeIn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FirstReg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AccountIn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeferTaxIn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApndxOOrP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DispOBCB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FromSeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ToSeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string canceltn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HideNTrans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeriesIn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromCardCo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToCardCo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SizeOfStru { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostFrDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocFrDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromDoc1Nu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToDoc1Nu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Serie1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Serie1CB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Doc1Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromDoc2Nu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToDoc2Nu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Serie2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Serie2CB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Doc2Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromDoc3Nu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToDoc3Nu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Serie3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Serie3CB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Doc3Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromDoc4Nu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToDoc4Nu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Serie4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Serie4CB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Doc4Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromDoc5Nu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToDoc5Nu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Serie5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Serie5CB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Doc5Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DateRBtn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MarkDocsIn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExRateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrsPerioTp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TrsPerioNu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TrsYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TrsAdjtNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DateType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncServDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GrpBySCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncUnReDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DoYearSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DefTaxOnly { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExcElDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QtrByMnt { get; set; }
    }
}