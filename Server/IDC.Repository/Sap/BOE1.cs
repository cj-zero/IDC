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
    public partial class BOE1 
    {
        public BOE1()
        {
          this.LineDitail= string.Empty;
          this.LineCurr= string.Empty;
          this.LineAcct= string.Empty;
          this.Line_A_C= string.Empty;
          this.Code= string.Empty;
          this.CredAcct= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineDitail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineMoney { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Line_A_C { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CredAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}