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
    public partial class OUKD 
    {
        public OUKD()
        {
          this.KeyName= string.Empty;
          this.UniqueKey= string.Empty;
          this.Action= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UniqueKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Action { get; set; }
    }
}