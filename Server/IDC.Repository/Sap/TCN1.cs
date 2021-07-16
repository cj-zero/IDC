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
    public partial class TCN1 
    {
        public TCN1()
        {
          this.ItemCCDNum= string.Empty;
          this.ItemCode= string.Empty;
          this.CntrOrigin= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCCDNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntrOrigin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccQtyAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccQtyAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccRelQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CstGrpCode { get; set; }
    }
}