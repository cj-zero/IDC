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
    public partial class RSC6 
    {
        public RSC6()
        {
          this.Remarks= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CapFactor1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CapFactor2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CapFactor3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CapFactor4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CapTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SngRunCap { get; set; }
    }
}