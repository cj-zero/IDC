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
    public partial class OHTY 
    {
        public OHTY()
        {
          this.name= string.Empty;
          this.descriptio= string.Empty;
          this.locked= string.Empty;
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
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string locked { get; set; }
    }
}