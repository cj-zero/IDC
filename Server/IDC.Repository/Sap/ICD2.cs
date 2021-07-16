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
    public partial class ICD2 
    {
        public ICD2()
        {
          this.BarCode= string.Empty;
          this.UomCode= string.Empty;
          this.IUomEntry= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BarCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UomCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UomQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CountQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Tk1UomQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Tk2UomQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Tk1CntQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Tk2CntQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ItmsPerUnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogIns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UgpEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TeamUomQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TeamCntQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IUomEntry { get; set; }
    }
}