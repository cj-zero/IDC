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
    public partial class BAL1 
    {
        public BAL1()
        {
          this.OBDate= DateTime.Now;
          this.WasPrevOB= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.WasUpdPrCB= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? OBDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OutQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InAmntLWA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InQtyLWA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LastTrnsID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WasPrevOB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CrossPRev { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WasUpdPrCB { get; set; }
    }
}