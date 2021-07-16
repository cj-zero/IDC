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
    public partial class OBTQ 
    {
        public OBTQ()
        {
          this.ItemCode= string.Empty;
          this.SysNumber= 0;
          this.WhsCode= string.Empty;
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
        public int SysNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CountQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MdAbsEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TrackingNt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TrackiNtLn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CCDQuant { get; set; }
    }
}