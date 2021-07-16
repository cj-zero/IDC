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
    public partial class VRT2 
    {
        public VRT2()
        {
          this.BPCode= string.Empty;
          this.BPName= string.Empty;
          this.DocDate= DateTime.Now;
          this.ItemNo= string.Empty;
          this.ItemDes= string.Empty;
          this.TaxCode= string.Empty;
          this.Currency= string.Empty;
          this.Remark= string.Empty;
          this.LegacyData= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? BPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemDes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ItemQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ItemPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LineType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LegacyData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
    }
}