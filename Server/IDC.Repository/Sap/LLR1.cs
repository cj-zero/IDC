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
    public partial class LLR1 
    {
        public LLR1()
        {
          this.ReportCode= string.Empty;
          this.Criteria= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReportCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Criteria { get; set; }
    }
}