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
    public partial class DWZ3 
    {
        public DWZ3()
        {
          this.AddChecked= string.Empty;
          this.InVatGroup= string.Empty;
          this.InTaxCode= string.Empty;
          this.FeVatGroup= string.Empty;
          this.FeTaxCode= string.Empty;
          this.Executed= string.Empty;
          this.Message= string.Empty;
          this.DocCur= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddChecked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IntrAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IntrAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IntrAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FeeAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FeeAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FeeAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InVatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InTaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FeVatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FeTaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Executed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocCur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? BPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LocCode { get; set; }
    }
}