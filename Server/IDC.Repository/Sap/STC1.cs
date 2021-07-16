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
    public partial class STC1 
    {
        public STC1()
        {
          this.STACode= string.Empty;
          this.TaxOnTCode= string.Empty;
          this.CstCodeIn= string.Empty;
          this.CstSuffix= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string STACode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STAType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxOnTCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TaxOnTType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EfctivRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? FmlId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstCodeIn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstSuffix { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
    }
}