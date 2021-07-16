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
    public partial class WOR3 
    {
        public WOR3()
        {
          this.WhsCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RToStock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RToStockSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IVLTransSe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IVLLayerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SnbSysNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SnbAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? INMSubLine { get; set; }
    }
}