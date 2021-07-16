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
    public partial class UDO1 
    {
        public UDO1()
        {
          this.TableName= string.Empty;
          this.LogName= string.Empty;
          this.SonName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TableName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LogName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SonName { get; set; }
    }
}