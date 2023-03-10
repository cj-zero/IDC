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
    public partial class ADP1 
    {
        public ADP1()
        {
          this.PrintOnAdd= string.Empty;
          this.ExprtOnAdd= string.Empty;
          this.RoundSums= string.Empty;
          this.Remark= string.Empty;
          this.PrintSums= string.Empty;
          this.VndrNum= string.Empty;
          this.PrnDscnt= string.Empty;
          this.SplitTran1= string.Empty;
          this.SplitTran2= string.Empty;
          this.SplitTran3= string.Empty;
          this.ShowBothNu= string.Empty;
          this.BaseRmrk= string.Empty;
          this.EngKBItem= string.Empty;
          this.EngKBCard= string.Empty;
          this.OrdrPicDef= string.Empty;
          this.SpltTrBOE1= string.Empty;
          this.CashPay= string.Empty;
          this.NonCashPay= string.Empty;
          this.CkeckPaper= string.Empty;
          this.AllowFuPos= string.Empty;
          this.ErdOutMode= string.Empty;
          this.ErdIncMode= string.Empty;
          this.ChkDupRef= string.Empty;
          this.CpyCVRef= string.Empty;
          this.BatchSerPr= string.Empty;
          this.YearTrans= string.Empty;
          this.ReopOrder= string.Empty;
          this.ForceReOrd= string.Empty;
          this.PrintRows= string.Empty;
          this.orderblock= string.Empty;
          this.RecomPkg= string.Empty;
          this.Enitemcost= string.Empty;
          this.ClosePQ= string.Empty;
          this.CpyPRPrice= string.Empty;
          this.EnSetCost= string.Empty;
          this.DftPLChk= string.Empty;
          this.EmailOnAdd= string.Empty;
          this.PDFOnAdd= string.Empty;
          this.EmailSbj= string.Empty;
          this.EmailBody= string.Empty;
          this.BlockWHT08= string.Empty;
          this.BlockExprt= string.Empty;
          this.BlockPrint= string.Empty;
          this.BlockMail= string.Empty;
          this.BlockToPDF= string.Empty;
          this.BlockFax= string.Empty;
          this.PoDropPrss= string.Empty;
          this.ShowCash= string.Empty;
          this.PRUseBPTax= string.Empty;
          this.EnblTtlEgD= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Copies { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrintOnAdd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExprtOnAdd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RoundSums { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrintSums { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VndrNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrnDscnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SplitTran1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SplitTran2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SplitTran3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowBothNu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseRmrk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? HandCopies { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EngKBItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EngKBCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrdrPicDef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpltTrBOE1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LineNumPPg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? JENumPPg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CashPay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NonCashPay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxUOPay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CkeckPaper { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AllowFuPos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ErdOutMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ErdIncMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChkDupRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CpyCVRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BatchSerPr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string YearTrans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ReconJeSer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReopOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ForceReOrd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrintRows { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string orderblock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RecomPkg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Enitemcost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ClosePQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CpyPRPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnSetCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DftPLChk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DfltPLSel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmailOnAdd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PDFOnAdd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmailSbj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmailBody { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockWHT08 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockExprt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockPrint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockMail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockToPDF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockFax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PoDropPrss { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowCash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PRUseBPTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnblTtlEgD { get; set; }
    }
}