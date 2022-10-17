using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Dapper.Contrib.Extensions;
using IDC.Repository.Dapper;

namespace IDC.Repository.Entities.NsapBone
{
    [ConnectionString("NsapBoneDbContext", "NsapBoneReadDbContext")]
    public partial class buy_por1
    {
        public buy_por1()
        {
            this.BaseRef = string.Empty;
            this.LineStatus = string.Empty;
            this.ItemCode = string.Empty;
            this.Dscription = string.Empty;
            this.Currency = string.Empty;
            this.WhsCode = string.Empty;
            this.AcctCode = string.Empty;
            this.DocDate = DateTime.Now;
            this.BaseCard = string.Empty;
            this.VatGroup = string.Empty;
            this.ObjType = string.Empty;
            this.unitMsr = string.Empty;
            this.U_WLLY = string.Empty;
            this.U_YYFX = string.Empty;
            this.U_ZXDH = string.Empty;
            this.U_TYWP = string.Empty;
            this.U_CPH = string.Empty;
            this.U_TYSL = string.Empty;
        }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Key]
        public int sbo_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Key]
        public int DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Key]
        public int LineNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TargetType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TrgetEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineStatus { get; set; }
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
        [Description("")]
        public decimal? Quantity { get; set; }
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
        public decimal? DiscPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalFrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SlpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrossBuyPr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PriceBefDi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PriceAfVAT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StockPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StockSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenQty { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenSumFC { get; set; }
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
        public short? TrnsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PackQty { get; set; }
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
        public decimal? GTotalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string unitMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NumPerMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? INMPrice { get; set; }
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
        public decimal? GrssProfFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>

        [Description("")]
        public decimal? OpenCreQty { get; set; }
  
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_WLLY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_YYFX { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZXDH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_TYWP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_CPH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_TYSL { get; set; }
        
    }
}
