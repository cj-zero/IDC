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
    public partial class ODAB 
    {
        public ODAB()
        {
          this.PackEntry= 0;
          this.DashbdCode= string.Empty;
          this.DashbdName= string.Empty;
          this.DashbdPath= string.Empty;
          this.Note= string.Empty;
          this.Status= string.Empty;
          this.JobFlag= string.Empty;
          this.JobType= string.Empty;
          this.JobSetting= string.Empty;
          this.RenewDate= DateTime.Now;
          this.ProcName= string.Empty;
          this.JobName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int PackEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DashbdCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DashbdName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DashbdPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Note { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JobFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JobType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JobSetting { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RenewDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RenewTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProcName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JobName { get; set; }
    }
}