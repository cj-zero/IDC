using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace IDC.Repository.Entities.NsapBone
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("NsapBoneDbContext","NsapBoneReadDbContext")]
    public partial class sale_rdr1 
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int sbo_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int LineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dscription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PriceBefDi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StockPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrderedQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PackQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenCreQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StockValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VisOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrssProfit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string unitMsr { get; set; }
    }
}