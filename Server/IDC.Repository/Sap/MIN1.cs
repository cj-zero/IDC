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
    public partial class MIN1 
    {
        public MIN1()
        {
          this.DocDate= DateTime.Now;
          this.DocDueDate= DateTime.Now;
          this.DocClsDate= DateTime.Now;
          this.Closed= string.Empty;
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
        public System.DateTime? DocDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocClsDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocExpense { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocDiscSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocRound { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Closed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MINumWnCls { get; set; }
    }
}