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
    public partial class RIT1 
    {
        public RIT1()
        {
          this.FixSumCurr= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Days { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IntrstPrct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FixedSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FixSumCurr { get; set; }
    }
}