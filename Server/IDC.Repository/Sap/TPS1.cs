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
    public partial class TPS1 
    {
        public TPS1()
        {
          this.DispOrder= 0;
          this.Mandatory= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int DispOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Mandatory { get; set; }
    }
}