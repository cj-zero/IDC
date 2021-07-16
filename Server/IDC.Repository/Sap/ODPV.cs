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
    public partial class ODPV 
    {
        public ODPV()
        {
          this.ItemCode= string.Empty;
          this.DprArea= string.Empty;
          this.PeriodCat= string.Empty;
          this.FromDate= DateTime.Now;
          this.ToDate= DateTime.Now;
          this.SpDprKey= string.Empty;
          this.SubPeriod= 0;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
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
        public System.DateTime? FromDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrdDprPlan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrdDprPost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrdDprAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpDprKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SpDprPlan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SpDprPost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SpDprAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int SubPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrdDprPln1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrdDprPst1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrdDprAct1 { get; set; }
    }
}