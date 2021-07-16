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
    public partial class MTH1V 
    {
        public MTH1V()
        {
          this.RefDate= DateTime.Now;
          this.DueDate= DateTime.Now;
          this.Ref1= string.Empty;
          this.Ref2= string.Empty;
          this.Ref3Line= string.Empty;
          this.Currency= string.Empty;
          this.LineMemo= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref3Line { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Debit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Credit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SYSDeb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SYSCred { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FCDebit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FCCredit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineMemo { get; set; }
    }
}