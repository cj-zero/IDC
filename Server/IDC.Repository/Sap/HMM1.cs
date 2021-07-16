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
    public partial class HMM1 
    {
        public HMM1()
        {
          this.ViewType= string.Empty;
          this.ViewName= string.Empty;
          this.MenuDesc= string.Empty;
          this.MenuEnable= string.Empty;
          this.IAEnable= string.Empty;
          this.SLEnable= string.Empty;
          this.SLExpose= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ViewType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ViewName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MenuDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MenuEnable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IAEnable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SLEnable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SLExpose { get; set; }
    }
}