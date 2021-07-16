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
    public partial class OVRT 
    {
        public OVRT()
        {
          this.TxInvRptDt= DateTime.Now;
          this.CardCode= string.Empty;
          this.BPAddress= string.Empty;
          this.version= string.Empty;
          this.NTSApprov= string.Empty;
          this.NTSeTaxNo= string.Empty;
          this.NTSApprNo= string.Empty;
          this.Remarks= string.Empty;
          this.OriNTSAppr= string.Empty;
          this.CardName= string.Empty;
          this.RptStatus= string.Empty;
          this.OriTaxInvN= string.Empty;
          this.TxInvPrint= string.Empty;
          this.Canceled= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TxInvRptDt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? SupBPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BlankNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Total { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ReportType { get; set; }
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
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OriNTSAppr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RptStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OriTaxInvN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TxInvPrint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Canceled { get; set; }
    }
}