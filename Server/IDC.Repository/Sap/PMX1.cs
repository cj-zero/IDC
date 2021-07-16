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
    public partial class PMX1 
    {
        public PMX1()
        {
          this.CateType= string.Empty;
          this.CateCode= string.Empty;
          this.Keyword= string.Empty;
          this.Category= string.Empty;
          this.Debit= string.Empty;
          this.Credit= string.Empty;
          this.FCDebit= string.Empty;
          this.FCCredit= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CateType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CateCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Keyword { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Debit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Credit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FCDebit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FCCredit { get; set; }
    }
}