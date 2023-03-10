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
    public partial class TRT1 
    {
        public TRT1()
        {
          this.AcctCode= string.Empty;
          this.Line_Descr= string.Empty;
          this.VatGroup= string.Empty;
          this.VatLine= string.Empty;
          this.CtrlAcct= string.Empty;
          this.OcrCode= string.Empty;
          this.TaxPostAcc= string.Empty;
          this.StaCode= string.Empty;
          this.TaxCode= string.Empty;
          this.OcrCode1= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.WtLiable= string.Empty;
          this.WTaxLine= string.Empty;
          this.Project= string.Empty;
          this.CemCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Line_Descr { get; set; }
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
        public string VatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CtrlAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TaxType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxPostAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StaCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StaType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WtLiable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTaxLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrossValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CemCode { get; set; }
    }
}