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
    public partial class USR6 
    {
        public USR6()
        {
          this.DigCrtPath= string.Empty;
          this.AcsDsbldBP= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DigCrtPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcsDsbldBP { get; set; }
    }
}