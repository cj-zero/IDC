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
    public partial class OSUL 
    {
        public OSUL()
        {
          this.RealName= string.Empty;
          this.LogReason= string.Empty;
          this.LogDetail= string.Empty;
          this.Mac= string.Empty;
          this.Machine= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.ChkHash= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RealName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LogReason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LogDetail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Mac { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Machine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChkHash { get; set; }
    }
}