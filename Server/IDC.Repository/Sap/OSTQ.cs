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
    public partial class OSTQ 
    {
        public OSTQ()
        {
          this.QueryNAme= string.Empty;
          this.QueryStr= string.Empty;
          this.Severity= string.Empty;
          this.QueryGroup= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QueryNAme { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QueryStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Severity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QueryGroup { get; set; }
    }
}