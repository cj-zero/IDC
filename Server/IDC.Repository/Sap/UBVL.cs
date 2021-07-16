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
    public partial class UBVL 
    {
        public UBVL()
        {
          this.CreateDate= DateTime.Now;
          this.ItemCode= string.Empty;
          this.DistNumber= string.Empty;
          this.TrValApply= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AccumType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ManagedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SysNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DistNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MdAbsEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrValApply { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TransValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InvValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CogsValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OverlapQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CogsQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CalcPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PriceDiff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InvDiff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Balance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccNegQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ILMEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ITLEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Cost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseDocEn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseLnNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DeltaAccT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RowAction { get; set; }
    }
}