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
    public partial class FAC2 
    {
        public FAC2()
        {
          this.DprArea= string.Empty;
          this.PeriodCat= string.Empty;
          this.VisOrder= 0;
          this.OldDprSt= string.Empty;
          this.NewDprSt= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DprArea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PeriodCat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int VisOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OldDprSt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NewDprSt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OldFactor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NewFactor { get; set; }
    }
}