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
    public partial class ORIT 
    {
        public ORIT()
        {
          this.Name= string.Empty;
          this.IncPartPay= string.Empty;
          this.OrigRate= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncPartPay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DayInMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrigRate { get; set; }
    }
}