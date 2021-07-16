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
    public partial class WTM4 
    {
        public WTM4()
        {
          this.opValue= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? opCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string opValue { get; set; }
    }
}