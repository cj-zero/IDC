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
    public partial class OHPS 
    {
        public OHPS()
        {
          this.name= string.Empty;
          this.descriptio= string.Empty;
          this.LocFields= string.Empty;
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
        public string LocFields { get; set; }
    }
}