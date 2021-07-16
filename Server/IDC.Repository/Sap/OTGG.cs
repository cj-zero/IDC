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
    public partial class OTGG 
    {
        public OTGG()
        {
          this.TargetName= string.Empty;
          this.TargetType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TargetName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TargetType { get; set; }
    }
}