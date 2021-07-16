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
    public partial class MSN3 
    {
        public MSN3()
        {
          this.ItemCode= string.Empty;
          this.BaseObj= string.Empty;
          this.BaseDocNum= string.Empty;
          this.BaseDue= DateTime.Now;
          this.StockType= string.Empty;
          this.ParentCode= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.WhsCode= string.Empty;
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
        public int? PeriodID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
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
        public string BaseObj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BaseDue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StockType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
    }
}