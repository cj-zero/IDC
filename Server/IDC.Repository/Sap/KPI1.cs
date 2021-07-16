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
    public partial class KPI1 
    {
        public KPI1()
        {
          this.FieldName= string.Empty;
          this.Method= string.Empty;
          this.DbType= string.Empty;
          this.DefValue= string.Empty;
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
        public int? Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FieldName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Method { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DbType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DefValue { get; set; }
    }
}