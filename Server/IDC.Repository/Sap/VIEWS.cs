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
    public partial class VIEWS 
    {
        public VIEWS()
        {
          this.ViewString= string.Empty;
          this.ViewType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ViewString { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ViewType { get; set; }
    }
}