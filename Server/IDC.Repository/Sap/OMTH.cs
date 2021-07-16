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
    public partial class OMTH 
    {
        public OMTH()
        {
          this.IsCard= string.Empty;
          this.MatchType= string.Empty;
          this.MatchDate= DateTime.Now;
          this.CurrType= string.Empty;
          this.DataSource= string.Empty;
          this.createDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Totals { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MatchType { get; set; }
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
        public System.DateTime? MatchDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CurrType { get; set; }
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
        public System.DateTime? createDate { get; set; }
    }
}