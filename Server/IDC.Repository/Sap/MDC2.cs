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
    public partial class MDC2 
    {
        public MDC2()
        {
          this.UserAction= string.Empty;
          this.DelContent= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserAction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DelContent { get; set; }
    }
}