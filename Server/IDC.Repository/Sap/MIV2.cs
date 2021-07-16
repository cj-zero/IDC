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
    public partial class MIV2 
    {
        public MIV2()
        {
          this.DocDate= DateTime.Now;
          this.ItemCode= string.Empty;
          this.ItemName= string.Empty;
          this.ItemCurr= string.Empty;
          this.ItemType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MinvNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ItemPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ItemRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ItemQuan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ItemTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineTotal { get; set; }
    }
}