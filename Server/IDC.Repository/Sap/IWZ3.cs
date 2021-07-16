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
    public partial class IWZ3 
    {
        public IWZ3()
        {
          this.BaseCurr= string.Empty;
          this.RevalDate= DateTime.Now;
          this.RealAcct= string.Empty;
          this.RevalOfsac= string.Empty;
          this.RevalType= string.Empty;
          this.ExeLine= string.Empty;
          this.RevCancel= string.Empty;
          this.RvCaclDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RevalPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RevalDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RevalSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BasePrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RealAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevalOfsac { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevalType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExeLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevCancel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RvCaclDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BalanceBef { get; set; }
    }
}