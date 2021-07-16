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
    public partial class IPF3 
    {
        public IPF3()
        {
          this.Dscription= string.Empty;
          this.LaCAllcAcc= string.Empty;
          this.VatGroup= string.Empty;
          this.CstmVatStk= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dscription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LaCAllcAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CustSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CustSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CustSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AccType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstmVatStk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CCDEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LineNum2 { get; set; }
    }
}