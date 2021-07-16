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
    public partial class WTC1 
    {
        public WTC1()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WtAbsEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTPercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumVatAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumDocTot { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumBaseAmn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumAccumAm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumPercpAm { get; set; }
    }
}