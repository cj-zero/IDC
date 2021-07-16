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
    public partial class OCRP 
    {
        public OCRP()
        {
          this.CrTypeName= string.Empty;
          this.DueTerms= string.Empty;
          this.InstalMent= string.Empty;
          this.Locked= string.Empty;
          this.DataSource= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreditCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DueTerms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinCredit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinToPay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxValid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InstalMent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
    }
}