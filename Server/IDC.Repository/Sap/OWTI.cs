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
    public partial class OWTI 
    {
        public OWTI()
        {
          this.Name= string.Empty;
          this.StartDate= DateTime.Now;
          this.Duration= string.Empty;
          this.LastUpdate= string.Empty;
          this.UnScheStDt= DateTime.Now;
          this.IsComplete= string.Empty;
          this.JobHanType= string.Empty;
          this.JobHanConf= string.Empty;
          this.IsActive= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TemplateId { get; set; }
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
        public int? RepeatCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Duration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LastUpdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UnScheStDt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UnScheStTi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UnScheReCt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsComplete { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JobHanType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JobHanConf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsActive { get; set; }
    }
}