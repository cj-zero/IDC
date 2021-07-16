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
    public partial class GBI9 
    {
        public GBI9()
        {
          this.RepItm= string.Empty;
          this.RepItmNo= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepItm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepItmNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PeriodAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? YearAmt { get; set; }
    }
}