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
    public partial class SCM3 
    {
        public SCM3()
        {
          this.SrcTable= string.Empty;
          this.SrcField= string.Empty;
          this.CalcCase= string.Empty;
          this.CalcTable= string.Empty;
          this.CondCase= string.Empty;
          this.CondTable= string.Empty;
          this.Grouping= string.Empty;
          this.CallProc= string.Empty;
          this.ExtCond= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcTable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CalcCase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CalcTable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CondCase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CondTable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Grouping { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CallProc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtCond { get; set; }
    }
}