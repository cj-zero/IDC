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
    public partial class DPO24 
    {
        public DPO24()
        {
          this.ItemCCDNum= string.Empty;
          this.CntrOrigin= string.Empty;
          this.ObjType= string.Empty;
        }

        
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
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCCDNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntrOrigin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SubLineNum { get; set; }
    }
}