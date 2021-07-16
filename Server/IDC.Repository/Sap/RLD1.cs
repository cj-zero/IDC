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
    public partial class RLD1 
    {
        public RLD1()
        {
          this.SourceFld= string.Empty;
          this.SourceType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SourceFld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OrderNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SourceType { get; set; }
    }
}