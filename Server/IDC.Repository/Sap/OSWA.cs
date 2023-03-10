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
    public partial class OSWA 
    {
        public OSWA()
        {
          this.DlvryIdNo= string.Empty;
          this.SnglCrtfNo= string.Empty;
          this.Advanced= string.Empty;
          this.WTHTypCd= string.Empty;
          this.SSFiscalCd= string.Empty;
          this.SSIName= string.Empty;
          this.SSICode= string.Empty;
          this.CompanyCd= string.Empty;
          this.Category= string.Empty;
          this.OthCntrbts= string.Empty;
          this.FiscalCode= string.Empty;
          this.FsCdTrdPty= string.Empty;
          this.FCdTrdPtyS= string.Empty;
          this.FscCdExpr= string.Empty;
          this.FsCdMnDbS= string.Empty;
          this.WHTNApdS= string.Empty;
          this.FsCdMnDbR= string.Empty;
          this.WHTNApdR= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FllTxInAdv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmntsOnhld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RTAsWth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RTAsAdv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SspndRegTx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MTAsWth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MTAsAdv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SspndMTTx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TxblPrYr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTHPrYr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ScrtyCntrP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ScrtyCntrS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpsRmbrsd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTHRmbrsd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string DlvryIdNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SnglCrtfNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ErnYr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Advanced { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTHTypCd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrssAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NtSbjctFrg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TxblAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTHAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SSFiscalCd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SSIName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SSICode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompanyCd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EmpeSSCntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EmprSSCntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OthCntrbts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VOthCntrbt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OthAmntDue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OthAmntPd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmntPdBfBr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmntPdByTr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FiscalCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TxblAmntE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TxAmntInAd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SspndWTHTx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AdRgTxIRPH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AdRgTxIRPA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SspdRgnlTx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AdCtTxIRWT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AdCtTxIWTA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SspndCtTx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FsCdTrdPty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FCdTrdPtyS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FscCdExpr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FsCdMnDbS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmntPdS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WHTApdS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WHTNApdS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FsCdMnDbR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmntPdR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WHTApdR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WHTNApdR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmntPdA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TxAppldA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmntPdB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TxAppldB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmntPdC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TxAppldC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmntPdD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TxAppldD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmtPvdNTxS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmtPvdNTxR { get; set; }
    }
}