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
    public partial class ODLL 
    {
        public ODLL()
        {
          this.DllName= string.Empty;
          this.DllDesp= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DllName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DllDesp { get; set; }
    }
}