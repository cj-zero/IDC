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
    public partial class OCUL 
    {
        public OCUL()
        {
          this.DateTime= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StartRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EventType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DateTime { get; set; }
    }
}