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
    public partial class OWTJ 
    {
        public OWTJ()
        {
          this.IsASync= string.Empty;
          this.Status= string.Empty;
          this.StartDate= DateTime.Now;
          this.JobHanConf= string.Empty;
          this.JobHanType= string.Empty;
          this.LastUpdate= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsASync { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
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
        [Browsable(false)]
        public int? TimerEtyId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JobHanConf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JobHanType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LastUpdate { get; set; }
    }
}