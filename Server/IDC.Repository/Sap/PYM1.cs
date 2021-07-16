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
    public partial class PYM1 
    {
        public PYM1()
        {
          this.CurrName= string.Empty;
          this.Choose= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CurrName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Choose { get; set; }
    }
}