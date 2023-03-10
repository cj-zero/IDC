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
    public partial class AGAR 
    {
        public AGAR()
        {
          this.PeriodCat= string.Empty;
          this.FinancYear= DateTime.Now;
          this.PeriodName= string.Empty;
          this.SubType= string.Empty;
          this.F_RefDate= DateTime.Now;
          this.T_RefDate= DateTime.Now;
          this.F_DueDate= DateTime.Now;
          this.T_DueDate= DateTime.Now;
          this.F_TaxDate= DateTime.Now;
          this.T_TaxDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.ItemCode= string.Empty;
          this.WhsCode= string.Empty;
          this.LicTradNum= string.Empty;
          this.ShipCountr= string.Empty;
          this.ShipState= string.Empty;
          this.Comments= string.Empty;
          this.CreateDate= DateTime.Now;
          this.RuleCode= string.Empty;
          this.GLMethod= string.Empty;
          this.Transfered= string.Empty;
          this.FromDate= DateTime.Now;
          this.ToDate= DateTime.Now;
          this.DfltExpn= string.Empty;
          this.DfltIncom= string.Empty;
          this.ExmptIncom= string.Empty;
          this.StockAct= string.Empty;
          this.COGM_Act= string.Empty;
          this.AlocCstAct= string.Empty;
          this.VariancAct= string.Empty;
          this.PricDifAct= string.Empty;
          this.NegStckAct= string.Empty;
          this.DfltLoss= string.Empty;
          this.DfltProfit= string.Empty;
          this.RturnngAct= string.Empty;
          this.ECIncome= string.Empty;
          this.ECExepnses= string.Empty;
          this.ForgnIncm= string.Empty;
          this.ForgnExpn= string.Empty;
          this.PurchseAct= string.Empty;
          this.PaReturnAc= string.Empty;
          this.PaOffsetAc= string.Empty;
          this.ExDiffAct= string.Empty;
          this.BalanceAct= string.Empty;
          this.DecresGlAc= string.Empty;
          this.IncresGlAc= string.Empty;
          this.WipAcct= string.Empty;
          this.WipVarAcct= string.Empty;
          this.WipOffset= string.Empty;
          this.StockOffst= string.Empty;
          this.StockRvAct= string.Empty;
          this.StkRvOfAct= string.Empty;
          this.CostRevAct= string.Empty;
          this.CostOffAct= string.Empty;
          this.ExpClrAct= string.Empty;
          this.ExpOfstAct= string.Empty;
          this.StkInTnAct= string.Empty;
          this.ShpdGdsAct= string.Empty;
          this.VatRevAct= string.Empty;
          this.ARCMAct= string.Empty;
          this.APCMAct= string.Empty;
          this.ARCMExpAct= string.Empty;
          this.ARCMFrnAct= string.Empty;
          this.APCMFrnAct= string.Empty;
          this.ARCMEUAct= string.Empty;
          this.APCMEUAct= string.Empty;
          this.PurBalAct= string.Empty;
          this.WhICenAct= string.Empty;
          this.WhOCenAct= string.Empty;
          this.Active= string.Empty;
          this.CmpPrivate= string.Empty;
          this.VatGroup= string.Empty;
          this.CardCode= string.Empty;
          this.FreeChrgSA= string.Empty;
          this.FreeChrgPU= string.Empty;
          this.UDF1= string.Empty;
          this.UDF2= string.Empty;
          this.UDF3= string.Empty;
          this.UDF4= string.Empty;
          this.UDF5= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PeriodCat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FinancYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Year { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PeriodName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PeriodNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? F_RefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? T_RefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? F_DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? T_DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? F_TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? T_TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItmsGrpCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BPGrpCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LicTradNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShipCountr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShipState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RuleCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GLMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FromDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltExpn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltIncom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExmptIncom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StockAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string COGM_Act { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AlocCstAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VariancAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PricDifAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NegStckAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltLoss { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltProfit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RturnngAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ECIncome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ECExepnses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ForgnIncm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ForgnExpn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurchseAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaReturnAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaOffsetAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExDiffAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BalanceAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DecresGlAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncresGlAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WipAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WipVarAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WipOffset { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StockOffst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StockRvAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StkRvOfAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostRevAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostOffAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpClrAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpOfstAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StkInTnAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShpdGdsAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatRevAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARCMAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string APCMAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARCMExpAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARCMFrnAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string APCMFrnAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARCMEUAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string APCMEUAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurBalAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhICenAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhOCenAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CmpPrivate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Usage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeChrgSA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeChrgPU { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UDF1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UDF2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UDF3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UDF4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UDF5 { get; set; }
    }
}