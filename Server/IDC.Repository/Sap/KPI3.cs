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
    public partial class KPI3 
    {
        public KPI3()
        {
          this.Type= string.Empty;
          this.FldName= string.Empty;
          this.FldMethod= string.Empty;
          this.Operator= string.Empty;
          this.DbType= string.Empty;
          this.FromValue= string.Empty;
          this.ToValue= string.Empty;
          this.DftValue= string.Empty;
          this.ParamType= string.Empty;
          this.UdqPh= string.Empty;
          this.UdqOp= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? KPIEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FldName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FldMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Operator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DbType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SqlType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DftValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UdqPh { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UdqOp { get; set; }
    }
}