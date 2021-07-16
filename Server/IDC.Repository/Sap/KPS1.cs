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
    public partial class KPS1 
    {
        public KPS1()
        {
          this.KpiName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KpiName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? KpiValue30 { get; set; }
    }
}