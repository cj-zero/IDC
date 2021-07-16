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
    public partial class FAC1 
    {
        public FAC1()
        {
          this.DprArea= string.Empty;
          this.TransType= string.Empty;
          this.OldDprType= string.Empty;
          this.NewDprType= string.Empty;
          this.OldDprDate= DateTime.Now;
          this.NewDprDate= DateTime.Now;
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
        public string TransType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OldDprType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NewDprType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OldUsfLife { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NewUsfLife { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? OldDprDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? NewDprDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OldSalVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NewSalVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OldTtlUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NewTtlUnit { get; set; }
    }
}