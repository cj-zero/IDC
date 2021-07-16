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
    public partial class ASI1 
    {
        public ASI1()
        {
          this.SrcTaxAcct= string.Empty;
          this.TarTaxAcct= string.Empty;
          this.SrcSubType= string.Empty;
          this.ITCType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SourceNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SrcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SrcStaType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcTaxAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SACEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TarStaType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TarTaxAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DistAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcSubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ITCType { get; set; }
    }
}