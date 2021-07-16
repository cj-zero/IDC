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
    public partial class SRT1 
    {
        public SRT1()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CardNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxAmt { get; set; }
    }
}