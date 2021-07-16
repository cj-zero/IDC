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
    public partial class ALR2 
    {
        public ALR2()
        {
          this.ColName= string.Empty;
          this.Link= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ColName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Link { get; set; }
    }
}