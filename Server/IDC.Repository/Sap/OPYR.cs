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
    public partial class OPYR 
    {
        public OPYR()
        {
          this.Descriptio= string.Empty;
          this.Default= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descriptio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Default { get; set; }
    }
}