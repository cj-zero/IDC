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
    public partial class WHT1 
    {
        public WHT1()
        {
          this.EffecDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EffecDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TdsRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SurRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CessRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? HscRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PmntTerms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IgstRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CgstRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SgstRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UtgstRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CsgstRate { get; set; }
    }
}