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
    public partial class SCR1 
    {
        public SCR1()
        {
          this.Value1= string.Empty;
          this.Table1= string.Empty;
          this.Field1= string.Empty;
          this.Cond1= string.Empty;
          this.Group1= string.Empty;
          this.Relation= string.Empty;
          this.Value2= string.Empty;
          this.Table2= string.Empty;
          this.Field2= string.Empty;
          this.Cond2= string.Empty;
          this.Group2= string.Empty;
          this.ExtCond1= string.Empty;
          this.ExtCond2= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Value1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Table1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Field1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Cond1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Group1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Relation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Value2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Table2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Field2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Cond2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Group2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtCond1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtCond2 { get; set; }
    }
}