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
    public partial class OACP 
    {
        public OACP()
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
          this.LinkAct_1= string.Empty;
          this.LinkAct_2= string.Empty;
          this.LinkAct_3= string.Empty;
          this.LinkAct_4= string.Empty;
          this.LinkAct_5= string.Empty;
          this.LinkAct_6= string.Empty;
          this.ComissAct= string.Empty;
          this.LinkAct_8= string.Empty;
          this.LinkAct_9= string.Empty;
          this.LinkAct_10= string.Empty;
          this.LinkAct_11= string.Empty;
          this.LinkAct_12= string.Empty;
          this.LinkAct_13= string.Empty;
          this.LinkAct_14= string.Empty;
          this.LinkAct_15= string.Empty;
          this.LinkAct_16= string.Empty;
          this.LinkAct_17= string.Empty;
          this.LinkAct_18= string.Empty;
          this.DfltIncom= string.Empty;
          this.ExmptIncom= string.Empty;
          this.DfltExpn= string.Empty;
          this.ForgnIncm= string.Empty;
          this.ECIncome= string.Empty;
          this.ForgnExpn= string.Empty;
          this.DfltRateDi= string.Empty;
          this.DecresGlAc= string.Empty;
          this.LinkAct_27= string.Empty;
          this.DftStockOB= string.Empty;
          this.LinkAct_19= string.Empty;
          this.LinkAct_20= string.Empty;
          this.LinkAct_21= string.Empty;
          this.LinkAct_22= string.Empty;
          this.LinkAct_23= string.Empty;
          this.LinkAct_24= string.Empty;
          this.LinkAct_25= string.Empty;
          this.LinkAct_26= string.Empty;
          this.IncresGlAc= string.Empty;
          this.RturnngAct= string.Empty;
          this.COGM_Act= string.Empty;
          this.AlocCstAct= string.Empty;
          this.VariancAct= string.Empty;
          this.PricDifAct= string.Empty;
          this.CDownPymnt= string.Empty;
          this.VDownPymnt= string.Empty;
          this.CBoERcvble= string.Empty;
          this.CBoEOnClct= string.Empty;
          this.CBoEPresnt= string.Empty;
          this.CBoEDiscnt= string.Empty;
          this.CUnpaidBoE= string.Empty;
          this.VBoEPayble= string.Empty;
          this.VAsstBoEPy= string.Empty;
          this.COpenDebts= string.Empty;
          this.VOpenDebts= string.Empty;
          this.PurchseAct= string.Empty;
          this.PaReturnAc= string.Empty;
          this.PaOffsetAc= string.Empty;
          this.LinkAct_28= string.Empty;
          this.ExDiffAct= string.Empty;
          this.BalanceAct= string.Empty;
          this.BnkChgAct= string.Empty;
          this.LinkAct_29= string.Empty;
          this.LinkAct_30= string.Empty;
          this.IncmAcct= string.Empty;
          this.ExpnAcct= string.Empty;
          this.VatRevAct= string.Empty;
          this.ExpClrAct= string.Empty;
          this.ExpOfstAct= string.Empty;
          this.CostRevAct= string.Empty;
          this.RepomoAct= string.Empty;
          this.WipVarAcct= string.Empty;
          this.SaleVatOff= string.Empty;
          this.PurcVatOff= string.Empty;
          this.DpmSalAct= string.Empty;
          this.DpmPurAct= string.Empty;
          this.ExpVarAct= string.Empty;
          this.CostOffAct= string.Empty;
          this.ECExepnses= string.Empty;
          this.StockAct= string.Empty;
          this.DflInPrcss= string.Empty;
          this.DfltInCstm= string.Empty;
          this.DfltProfit= string.Empty;
          this.DfltLoss= string.Empty;
          this.VAssets= string.Empty;
          this.StockRvAct= string.Empty;
          this.StkRvOfAct= string.Empty;
          this.WipAcct= string.Empty;
          this.DfltCard= string.Empty;
          this.ShpdGdsAct= string.Empty;
          this.GlRvOffAct= string.Empty;
          this.OverpayAP= string.Empty;
          this.UndrpayAP= string.Empty;
          this.OverpayAR= string.Empty;
          this.UndrpayAR= string.Empty;
          this.ARCMAct= string.Empty;
          this.ARCMExpAct= string.Empty;
          this.ARCMFrnAct= string.Empty;
          this.ARCMEUAct= string.Empty;
          this.APCMAct= string.Empty;
          this.APCMFrnAct= string.Empty;
          this.APCMEUAct= string.Empty;
          this.NegStckAct= string.Empty;
          this.StkInTnAct= string.Empty;
          this.GLGainXdif= string.Empty;
          this.GLLossXdif= string.Empty;
          this.AmountDiff= string.Empty;
          this.SlfInvIncm= string.Empty;
          this.SlfInvExpn= string.Empty;
          this.OnHoldAct= string.Empty;
          this.PlaAct= string.Empty;
          this.ICClrAct= string.Empty;
          this.OCClrAct= string.Empty;
          this.PurBalAct= string.Empty;
          this.WhICenAct= string.Empty;
          this.WhOCenAct= string.Empty;
          this.SalDpmInt= string.Empty;
          this.PurDpmInt= string.Empty;
          this.ExrateOnDt= string.Empty;
          this.EURecvAct= string.Empty;
          this.EUPayAct= string.Empty;
          this.WipOffset= string.Empty;
          this.StockOffst= string.Empty;
          this.DunIntrst= string.Empty;
          this.DunFee= string.Empty;
          this.TDSInterst= string.Empty;
          this.TDSCharges= string.Empty;
          this.SrvTaxClr= string.Empty;
          this.ARConDiffG= string.Empty;
          this.ARConDiffL= string.Empty;
          this.APConDiffG= string.Empty;
          this.APConDiffL= string.Empty;
          this.GLConDiffG= string.Empty;
          this.GLConDiffL= string.Empty;
          this.FreeChrgSA= string.Empty;
          this.FreeChrgPU= string.Empty;
          this.TDSFee= string.Empty;
          this.ResRevenue= string.Empty;
          this.ResExpense= string.Empty;
          this.ResSalesCr= string.Empty;
          this.ResPurchCr= string.Empty;
          this.ResNotInv= string.Empty;
          this.ResStdExp1= string.Empty;
          this.ResStdExp2= string.Empty;
          this.ResStdExp3= string.Empty;
          this.ResStdExp4= string.Empty;
          this.ResStdExp5= string.Empty;
          this.ResStdExp6= string.Empty;
          this.ResStdExp7= string.Empty;
          this.ResStdExp8= string.Empty;
          this.ResStdExp9= string.Empty;
          this.ResStdEx10= string.Empty;
          this.ResWipAct= string.Empty;
          this.ResScrapAc= string.Empty;
          this.WipOffPlAc= string.Empty;
          this.ResOffPlAc= string.Empty;
          this.ERDInARAct= string.Empty;
          this.ERDInAPAct= string.Empty;
          this.CSDInARAct= string.Empty;
          this.CSDInAPAct= string.Empty;
          this.GSTInAct= string.Empty;
          this.GSTInterst= string.Empty;
          this.GSTCharges= string.Empty;
          this.GSTFee= string.Empty;
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
        public int? LogInstanc { get; set; }
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
        public string LinkAct_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ComissAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_18 { get; set; }
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
        public string DfltExpn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ForgnIncm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ECIncome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ForgnExpn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltRateDi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DecresGlAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DftStockOB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncresGlAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RturnngAct { get; set; }
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
        public string CDownPymnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VDownPymnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CBoERcvble { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CBoEOnClct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CBoEPresnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CBoEDiscnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CUnpaidBoE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VBoEPayble { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VAsstBoEPy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string COpenDebts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VOpenDebts { get; set; }
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
        public string LinkAct_28 { get; set; }
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
        public string BnkChgAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkAct_30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncmAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpnAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatRevAct { get; set; }
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
        public string CostRevAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepomoAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WipVarAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SaleVatOff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurcVatOff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpmSalAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpmPurAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpVarAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostOffAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ECExepnses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StockAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflInPrcss { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltInCstm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltProfit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltLoss { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VAssets { get; set; }
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
        public string WipAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShpdGdsAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GlRvOffAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OverpayAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UndrpayAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OverpayAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UndrpayAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARCMAct { get; set; }
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
        public string ARCMEUAct { get; set; }
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
        public string GLGainXdif { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GLLossXdif { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AmountDiff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SlfInvIncm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SlfInvExpn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OnHoldAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PlaAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ICClrAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OCClrAct { get; set; }
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
        public string SalDpmInt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurDpmInt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExrateOnDt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EURecvAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EUPayAct { get; set; }
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
        public string DunIntrst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DunFee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? SnapShotId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TDSInterst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TDSCharges { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrvTaxClr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARConDiffG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARConDiffL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string APConDiffG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string APConDiffL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GLConDiffG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GLConDiffL { get; set; }
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
        public string TDSFee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResRevenue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResExpense { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResSalesCr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResPurchCr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResNotInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResStdExp1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResStdExp2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResStdExp3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResStdExp4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResStdExp5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResStdExp6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResStdExp7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResStdExp8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResStdExp9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResStdEx10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResWipAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResScrapAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WipOffPlAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResOffPlAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ERDInARAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ERDInAPAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CSDInARAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CSDInAPAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GSTInAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GSTInterst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GSTCharges { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GSTFee { get; set; }
    }
}