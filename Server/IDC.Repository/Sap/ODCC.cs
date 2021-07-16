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
    public partial class ODCC 
    {
        public ODCC()
        {
          this.Enable= string.Empty;
          this.CronString= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Enable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Start { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CronString { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
    }
}