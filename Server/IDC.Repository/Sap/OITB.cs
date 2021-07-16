﻿using System;
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
    public partial class OITB 
    {
        public OITB()
        {
          this.ItmsGrpNam= string.Empty;
          this.Locked= string.Empty;
          this.DataSource= string.Empty;
          this.BalInvntAc= string.Empty;
          this.SaleCostAc= string.Empty;
          this.TransferAc= string.Empty;
          this.RevenuesAc= string.Empty;
          this.VarianceAc= string.Empty;
          this.DecreasAc= string.Empty;
          this.IncreasAc= string.Empty;
          this.ReturnAc= string.Empty;
          this.ExpensesAc= string.Empty;
          this.EURevenuAc= string.Empty;
          this.EUExpensAc= string.Empty;
          this.FrRevenuAc= string.Empty;
          this.FrExpensAc= string.Empty;
          this.ExmptIncom= string.Empty;
          this.Alert= string.Empty;
          this.PriceDifAc= string.Empty;
          this.ExchangeAc= string.Empty;
          this.BalanceAcc= string.Empty;
          this.PurchaseAc= string.Empty;
          this.PAReturnAc= string.Empty;
          this.PurchOfsAc= string.Empty;
          this.ShpdGdsAct= string.Empty;
          this.VatRevAct= string.Empty;
          this.DecresGlAc= string.Empty;
          this.IncresGlAc= string.Empty;
          this.InvntSys= string.Empty;
          this.PlaningSys= string.Empty;
          this.PrcrmntMtd= string.Empty;
          this.StokRvlAct= string.Empty;
          this.StkOffsAct= string.Empty;
          this.WipAcct= string.Empty;
          this.WipVarAcct= string.Empty;
          this.CostRvlAct= string.Empty;
          this.CstOffsAct= string.Empty;
          this.ExpClrAct= string.Empty;
          this.ExpOfstAct= string.Empty;
          this.Object= string.Empty;
          this.createDate= DateTime.Now;
          this.updateDate= DateTime.Now;
          this.ARCMAct= string.Empty;
          this.ARCMFrnAct= string.Empty;
          this.ARCMEUAct= string.Empty;
          this.ARCMExpAct= string.Empty;
          this.APCMAct= string.Empty;
          this.APCMFrnAct= string.Empty;
          this.APCMEUAct= string.Empty;
          this.RevRetAct= string.Empty;
          this.ItemClass= string.Empty;
          this.MatType= string.Empty;
          this.ProductSrc= string.Empty;
          this.NegStckAct= string.Empty;
          this.StkInTnAct= string.Empty;
          this.PurBalAct= string.Empty;
          this.WhICenAct= string.Empty;
          this.WhOCenAct= string.Empty;
          this.WipOffset= string.Empty;
          this.StockOffst= string.Empty;
          this.RuleCode= string.Empty;
          this.CompoWH= string.Empty;
          this.FreeChrgSA= string.Empty;
          this.FreeChrgPU= string.Empty;
          this.RawMtrl= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmsGrpNam { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BalInvntAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SaleCostAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransferAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevenuesAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VarianceAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DecreasAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncreasAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReturnAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpensesAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EURevenuAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EUExpensAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrRevenuAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrExpensAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExmptIncom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CycleCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Alert { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriceDifAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExchangeAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BalanceAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurchaseAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PAReturnAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurchOfsAc { get; set; }
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
        public string InvntSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PlaningSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrcrmntMtd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? OrdrIntrvl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrdrMulti { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinOrdrQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LeadTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StokRvlAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StkOffsAct { get; set; }
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
        public string CostRvlAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstOffsAct { get; set; }
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
        public string Object { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? logInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? createDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? userSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? updateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARCMAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARCMFrnAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARCMEUAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARCMExpAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string APCMAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string APCMFrnAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string APCMEUAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevRetAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemClass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OSvcCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISvcCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ServiceGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NCMCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MatType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MatGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProductSrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NegStckAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StkInTnAct { get; set; }
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
        public int? UgpEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IUoMEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ToleranDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RuleCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompoWH { get; set; }
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
        public string RawMtrl { get; set; }
    }
}