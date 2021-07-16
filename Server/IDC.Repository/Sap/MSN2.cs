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
    public partial class MSN2 
    {
        public MSN2()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Initial { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InitialOrg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InStock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OutStock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Final { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FinalOrg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Requests { get; set; }
    }
}