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
    public partial class OWFI 
    {
        public OWFI()
        {
          this.Creator= string.Empty;
          this.Status= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExecID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TemplateID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Creator { get; set; }
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
        public short? StartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? IsAutoStar { get; set; }
    }
}