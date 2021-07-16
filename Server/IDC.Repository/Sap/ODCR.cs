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
    public partial class ODCR 
    {
        public ODCR()
        {
          this.RuleDesc= string.Empty;
          this.PastRcp= string.Empty;
          this.AutoATP= string.Empty;
          this.SLDUncfm= string.Empty;
          this.AllowUncfm= string.Empty;
          this.CmltStrtg= string.Empty;
          this.DeliStrtg= string.Empty;
          this.validFor= string.Empty;
          this.validFrom= string.Empty;
          this.validTo= string.Empty;
          this.frozenFor= string.Empty;
          this.frozenFrom= string.Empty;
          this.frozenTo= string.Empty;
          this.Locked= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RuleDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PastRcp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoATP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SLDUncfm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AllowUncfm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CmltStrtg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeliStrtg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MaxPrpsls { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string validFor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string validFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string validTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string frozenFor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string frozenFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string frozenTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
    }
}