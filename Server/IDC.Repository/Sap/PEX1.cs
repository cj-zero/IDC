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
    public partial class PEX1 
    {
        public PEX1()
        {
          this.PayRunDate= DateTime.Now;
          this.VendorNum= string.Empty;
          this.CustNum= string.Empty;
          this.PaymMethod= string.Empty;
          this.FiscalYear= DateTime.Now;
          this.VendRefNum= string.Empty;
          this.ObjType= string.Empty;
          this.DocDate= DateTime.Now;
          this.TaxDate= DateTime.Now;
          this.CrdGLAcct= string.Empty;
          this.DocCurr= string.Empty;
          this.DocRemarks= string.Empty;
          this.DocPymRef= string.Empty;
          this.DocLocCurr= string.Empty;
          this.FreeText1= string.Empty;
          this.FreeText2= string.Empty;
          this.FreeText3= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PayRunDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PaymWizCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VendorNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CustNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaymMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PaymDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FiscalYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VendRefNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdGLAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTaxAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DoxTxAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocRemarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DocPrmTerm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocPymRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocLocCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PymTermPer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PymNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PayOrderNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeText1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeText2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeText3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? vatApplied { get; set; }
    }
}