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
    public partial class DATB 
    {
        public DATB()
        {
          this.TaxAcct= string.Empty;
          this.IsPLA= string.Empty;
          this.IsTaxCred= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LocCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? NfTaxId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TaxComId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MatType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ArchBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsPLA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsTaxCred { get; set; }
    }
}