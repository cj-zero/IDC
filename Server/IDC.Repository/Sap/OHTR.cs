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
    public partial class OHTR 
    {
        public OHTR()
        {
          this.name= string.Empty;
          this.descriptio= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string descriptio { get; set; }
    }
}