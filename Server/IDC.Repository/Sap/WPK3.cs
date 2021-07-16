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
    public partial class WPK3 
    {
        public WPK3()
        {
          this.FldName= string.Empty;
          this.FldMethod= string.Empty;
          this.DbType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DsbrdEntry { get; set; }
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
        public string DbType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SqlType { get; set; }
    }
}