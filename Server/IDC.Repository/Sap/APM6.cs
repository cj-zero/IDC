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
    public partial class APM6 
    {
        public APM6()
        {
          this.Chargeable= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ACTIVITYID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Charged { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Chargeable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}