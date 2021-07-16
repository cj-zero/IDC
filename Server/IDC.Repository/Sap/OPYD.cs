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
    public partial class OPYD 
    {
        public OPYD()
        {
          this.Name= string.Empty;
          this.UseMinPay= string.Empty;
          this.ArePayMeth= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TolerDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinCashDis { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseMinPay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinPayAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinPayAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArePayMeth { get; set; }
    }
}