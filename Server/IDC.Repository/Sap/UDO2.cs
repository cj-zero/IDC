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
    public partial class UDO2 
    {
        public UDO2()
        {
          this.ColAlias= string.Empty;
          this.ColumnDesc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ColAlias { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ColumnDesc { get; set; }
    }
}