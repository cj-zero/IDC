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
    public partial class AHE7 
    {
        public AHE7()
        {
          this.ConName= string.Empty;
          this.PmntNotes= string.Empty;
          this.BankName= string.Empty;
          this.BankCode= string.Empty;
          this.BankAcct= string.Empty;
          this.ANCurrency= string.Empty;
          this.AGCurrency= string.Empty;
          this.Sequence= string.Empty;
          this.EnBnkAcct= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ConName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PmntNotes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ANCurrency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AGCurrency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Sequence { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnBnkAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}