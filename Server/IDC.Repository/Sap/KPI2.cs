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
    public partial class KPI2 
    {
        public KPI2()
        {
          this.Type= string.Empty;
          this.Color= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? KPIEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? From { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Color { get; set; }
    }
}