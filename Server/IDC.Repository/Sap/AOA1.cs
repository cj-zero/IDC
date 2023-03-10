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
    public partial class AOA1 
    {
        public AOA1()
        {
          this.ItemCode= string.Empty;
          this.ItemName= string.Empty;
          this.Currency= string.Empty;
          this.FreeTxt= string.Empty;
          this.InvntryUom= string.Empty;
          this.WrrtyEnd= DateTime.Now;
          this.LineStatus= string.Empty;
          this.UomCode= string.Empty;
          this.Project= string.Empty;
          this.TaxCode= string.Empty;
          this.EncryptIV= string.Empty;
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
        public string ItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItemGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PlanQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UnitPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CumQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CumAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CumAmntLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeTxt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvntryUom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VisOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RetPortion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? WrrtyEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PlanAmtLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PlanAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Discount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UomEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UomCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NumPerMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UndlvQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UndlvAmntL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UndlvAmntF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TrnspCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TAXRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PlVatAmtLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PlVatAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CumVtAmtLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CumVtAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}