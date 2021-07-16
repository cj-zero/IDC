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
    public partial class BTA2 
    {
        public BTA2()
        {
          this.TaxEntry= 0;
          this.TaxLine= 0;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int TaxEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int TaxLine { get; set; }
    }
}