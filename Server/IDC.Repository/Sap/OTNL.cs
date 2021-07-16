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
    public partial class OTNL 
    {
        public OTNL()
        {
          this.WhsCode= string.Empty;
          this.CCDNum= string.Empty;
          this.ItemCode= string.Empty;
          this.DirectImp= string.Empty;
          this.CntrOrigin= string.Empty;
          this.CreateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TrNtAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TrNtLineNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseLnNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CCDNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DirectImp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntrOrigin { get; set; }
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
        public decimal? AccRelQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CCDQty { get; set; }
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
        public decimal? OnHandQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OILMEntry { get; set; }
    }
}