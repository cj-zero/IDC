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
    public partial class OADM 
    {
        public OADM()
        {
          this.CompnyName= string.Empty;
          this.CompnyAddr= string.Empty;
          this.Country= string.Empty;
          this.PrintHeadr= string.Empty;
          this.Phone1= string.Empty;
          this.Phone2= string.Empty;
          this.Fax= string.Empty;
          this.E_Mail= string.Empty;
          this.Manager= string.Empty;
          this.CompType= string.Empty;
          this.MainCurncy= string.Empty;
          this.SysCurrncy= string.Empty;
          this.DispPosDeb= string.Empty;
          this.DfltVendPM= string.Empty;
          this.DirectRate= string.Empty;
          this.AutoITW= string.Empty;
          this.BankCountr= string.Empty;
          this.TaxIdNum= string.Empty;
          this.RevOffice= string.Empty;
          this.FreeZoneNo= string.Empty;
          this.DdctFileNo= string.Empty;
          this.VatCharge= string.Empty;
          this.PayOutVat= string.Empty;
          this.VendorDdct= string.Empty;
          this.CustmrDdct= string.Empty;
          this.DdctExpire= DateTime.Now;
          this.DdctOffice= string.Empty;
          this.WTLiable= string.Empty;
          this.DfltCustPM= string.Empty;
          this.AllowFuPos= string.Empty;
          this.UseProdWip= string.Empty;
          this.CurrPeriod= string.Empty;
          this.XmlPath= string.Empty;
          this.BSInstled= string.Empty;
          this.UseShpdGd= string.Empty;
          this.UseExtRpt= string.Empty;
          this.ERpPerType= string.Empty;
          this.DfSVatExmp= string.Empty;
          this.DfPVatExmp= string.Empty;
          this.Manager1= string.Empty;
          this.Manager1F= string.Empty;
          this.CCMask= string.Empty;
          this.ObligLimit= string.Empty;
          this.CreditLimt= string.Empty;
          this.SalesLimit= string.Empty;
          this.DlnLimit= string.Empty;
          this.OrderLimit= string.Empty;
          this.AddDlnBlnc= string.Empty;
          this.CreditDpst= string.Empty;
          this.MultiLang= string.Empty;
          this.DflWebSite= string.Empty;
          this.DflFTPSite= string.Empty;
          this.UseTax= string.Empty;
          this.RevisionPo= string.Empty;
          this.Reindex= string.Empty;
          this.DllPath= string.Empty;
          this.TaxIdValid= string.Empty;
          this.PchName= string.Empty;
          this.RpcName= string.Empty;
          this.PdnName= string.Empty;
          this.RpdName= string.Empty;
          this.PorName= string.Empty;
          this.LevelWarn= string.Empty;
          this.CrdCommUse= string.Empty;
          this.ItmCommUse= string.Empty;
          this.SlpCommUse= string.Empty;
          this.SaleProfit= string.Empty;
          this.GrossBySal= string.Empty;
          this.TreePricOn= string.Empty;
          this.AddVat= string.Empty;
          this.BaseFld= string.Empty;
          this.ClosedQuot= string.Empty;
          this.UseCode= string.Empty;
          this.Code1= string.Empty;
          this.Code2= string.Empty;
          this.Code3= string.Empty;
          this.Code4= string.Empty;
          this.DdAutoRun= string.Empty;
          this.DdNextDue= DateTime.Now;
          this.CmpnyAddrF= string.Empty;
          this.DflTaxCode= string.Empty;
          this.PrintHdrF= string.Empty;
          this.Phone1F= string.Empty;
          this.Phone2F= string.Empty;
          this.FaxF= string.Empty;
          this.ManagerF= string.Empty;
          this.TimeFormat= string.Empty;
          this.CigCup= string.Empty;
          this.DateFormat= string.Empty;
          this.DateSep= string.Empty;
          this.FcNoBlnc= string.Empty;
          this.ChangeRdr= string.Empty;
          this.MultiCurr= string.Empty;
          this.PickParDlv= string.Empty;
          this.RoundRmrk= string.Empty;
          this.ISRBillerI= string.Empty;
          this.SysCNoEdit= string.Empty;
          this.RefDNoEdit= string.Empty;
          this.DfltWhs= string.Empty;
          this.TaxDNoEdit= string.Empty;
          this.DfSVatItem= string.Empty;
          this.DfSVatServ= string.Empty;
          this.DfPVatItem= string.Empty;
          this.DfPVatServ= string.Empty;
          this.DoBudget= string.Empty;
          this.CustIdNum= string.Empty;
          this.BgtBlock= string.Empty;
          this.BgtWarning= string.Empty;
          this.BdgtPORDoc= string.Empty;
          this.BdgtAcctng= string.Empty;
          this.ContInvnt= string.Empty;
          this.InvntSystm= string.Empty;
          this.ApplicIFRS= string.Empty;
          this.MltpBrnchs= string.Empty;
          this.EnblSrvTax= string.Empty;
          this.RoundVat= string.Empty;
          this.BdgtPDNDoc= string.Empty;
          this.IRSFileNo= string.Empty;
          this.DeferrTax= string.Empty;
          this.DflBnkCode= string.Empty;
          this.DflBnkAcct= string.Empty;
          this.DflBranch= string.Empty;
          this.UsePaSys= string.Empty;
          this.Serv_Usr= string.Empty;
          this.Serv_Pass= string.Empty;
          this.ParamPath= string.Empty;
          this.ExcelPath= string.Empty;
          this.TaxIdNum2= string.Empty;
          this.TaxIdNum3= string.Empty;
          this.DecSep= string.Empty;
          this.ThousSep= string.Empty;
          this.CurOnRight= string.Empty;
          this.WarnByWhs= string.Empty;
          this.PriceSys= string.Empty;
          this.useDdctTrc= string.Empty;
          this.useDocWrf= string.Empty;
          this.BtchStatus= string.Empty;
          this.OrderBatch= string.Empty;
          this.GLMethod= string.Empty;
          this.SetSriUniq= string.Empty;
          this.SriUniqFld= string.Empty;
          this.TaxRateDet= string.Empty;
          this.RefreshQty= string.Empty;
          this.StockNoBas= string.Empty;
          this.CentPmtInc= string.Empty;
          this.CentPmtOut= string.Empty;
          this.ChCtrAPAct= string.Empty;
          this.ChCtrARAct= string.Empty;
          this.PACUsrName= string.Empty;
          this.PACPasswrd= string.Empty;
          this.CaredType= string.Empty;
          this.PBSNumber= string.Empty;
          this.PBSGroupNo= string.Empty;
          this.OrgNumber= string.Empty;
          this.ActSep= string.Empty;
          this.DspBokpWin= string.Empty;
          this.SHandleWT= string.Empty;
          this.SDfltWT= string.Empty;
          this.IncresGlAc= string.Empty;
          this.PHandleWT= string.Empty;
          this.PDfltWT= string.Empty;
          this.ExWTLiabl= string.Empty;
          this.free84= string.Empty;
          this.AllowPostZ= string.Empty;
          this.EnableRO= string.Empty;
          this.UalLastDel= DateTime.Now;
          this.NegAmount= string.Empty;
          this.EnbDocOpt= string.Empty;
          this.HldCode= string.Empty;
          this.AlphaDoc= string.Empty;
          this.EDocURL2= string.Empty;
          this.EnPriceMod= string.Empty;
          this.TaaSEnable= string.Empty;
          this.TaaSUser= string.Empty;
          this.OrderBlock= string.Empty;
          this.RoundMthd= string.Empty;
          this.AdrsFromWH= string.Empty;
          this.OrderParty= string.Empty;
          this.CrtfcateNO= string.Empty;
          this.ExpireDate= DateTime.Now;
          this.NINum= string.Empty;
          this.TaaSPass= string.Empty;
          this.TaaSAutURL= string.Empty;
          this.CfwAsnMust= string.Empty;
          this.TaaSURL= string.Empty;
          this.TaaSSaleAc= string.Empty;
          this.TaxRegime= string.Empty;
          this.AliasName= string.Empty;
          this.DftJPELine= string.Empty;
          this.RdrConfrmd= string.Empty;
          this.PorConfrmd= string.Empty;
          this.TaaSPurcAc= string.Empty;
          this.AdvImagePr= string.Empty;
          this.TaxMethod= string.Empty;
          this.WallPaper= string.Empty;
          this.RndToTDec= string.Empty;
          this.SDfltITWT= string.Empty;
          this.PDfltITWT= string.Empty;
          this.CheckFiles= string.Empty;
          this.DsplyRates= string.Empty;
          this.DfActCurr= string.Empty;
          this.defTaxVend= string.Empty;
          this.RcrFlag= string.Empty;
          this.RclFlag= string.Empty;
          this.ContactLog= string.Empty;
          this.ShowNewMsg= string.Empty;
          this.OpenCdt= string.Empty;
          this.AutoVat= string.Empty;
          this.ConsumeFCT= string.Empty;
          this.ConsumeMtd= string.Empty;
          this.IsPAPrn= string.Empty;
          this.ShowNewTsk= string.Empty;
          this.TaxCodeCst= string.Empty;
          this.TaxCodeVnd= string.Empty;
          this.State= string.Empty;
          this.free83= string.Empty;
          this.OpenCredit= string.Empty;
          this.OpenDps= string.Empty;
          this.AltBOEPost= string.Empty;
          this.LDiscTotal= string.Empty;
          this.DfltDunTrm= string.Empty;
          this.Profession= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.DflBCACode= string.Empty;
          this.IgrAllCash= string.Empty;
          this.TaxPayerRf= string.Empty;
          this.EmployerRf= string.Empty;
          this.PStatAutCh= string.Empty;
          this.RepBusType= string.Empty;
          this.RepBusOthr= string.Empty;
          this.BrachNum= string.Empty;
          this.BuisnesDsc= string.Empty;
          this.ReptMethod= string.Empty;
          this.AcctMethod= string.Empty;
          this.Bookpitype= string.Empty;
          this.ActSoftNam= string.Empty;
          this.OpnClsRmrk= string.Empty;
          this.TaxRndRule= string.Empty;
          this.NegTax= string.Empty;
          this.ZeroLine= string.Empty;
          this.GBOpenFile= string.Empty;
          this.GBIntface= string.Empty;
          this.WTRndRule= string.Empty;
          this.DspFrznBP= string.Empty;
          this.DspFrznITM= string.Empty;
          this.NewDPRCus= string.Empty;
          this.ServNature= string.Empty;
          this.PickLimit= string.Empty;
          this.UseProdPL= string.Empty;
          this.ExRtDefTax= string.Empty;
          this.BoletoPath= string.Empty;
          this.MMLastImpD= DateTime.Now;
          this.CpyExhRate= string.Empty;
          this.GTSOutPath= string.Empty;
          this.UseMltDims= string.Empty;
          this.MDStyle= string.Empty;
          this.GTSInPath= string.Empty;
          this.GTSSep= string.Empty;
          this.RspOverAmt= string.Empty;
          this.DRBlock1= string.Empty;
          this.DRBlock2= string.Empty;
          this.DRBlock3= string.Empty;
          this.DRBlock4= string.Empty;
          this.DRBlock5= string.Empty;
          this.PrjBlock= string.Empty;
          this.SimReport= string.Empty;
          this.BackOrder= string.Empty;
          this.HQLocation= string.Empty;
          this.DigCrtPath= string.Empty;
          this.EnbApprDI= string.Empty;
          this.ChBPSerie= string.Empty;
          this.ChItmSerie= string.Empty;
          this.ETRTaxPers= string.Empty;
          this.PCN874RTyp= string.Empty;
          this.BTWDecProv= string.Empty;
          this.BTWDcPrvID= string.Empty;
          this.BTWName= string.Empty;
          this.BTWStreet= string.Empty;
          this.BTWCity= string.Empty;
          this.BTWZip= string.Empty;
          this.BTWPhone= string.Empty;
          this.ETRPhoneNo= string.Empty;
          this.EDTestMode= string.Empty;
          this.EDocGenTyp= string.Empty;
          this.EDocPass= string.Empty;
          this.EDProcess= string.Empty;
          this.PAC= string.Empty;
          this.NotifAlert= string.Empty;
          this.NotifEmail= string.Empty;
          this.EOutputPth= string.Empty;
          this.EDocURL1= string.Empty;
          this.ETRFaxNo= string.Empty;
          this.ETRMgrPhn= string.Empty;
          this.CrtLineRFQ= string.Empty;
          this.DflJET= string.Empty;
          this.OnlyPaidIn= string.Empty;
          this.PDDEnabled= string.Empty;
          this.AutoAddUoM= string.Empty;
          this.AutoAddPkg= string.Empty;
          this.BinActivat= string.Empty;
          this.InstFixAst= string.Empty;
          this.DeprecCalc= string.Empty;
          this.FixAstMod= string.Empty;
          this.SopPath= string.Empty;
          this.NewAcctDe= string.Empty;
          this.ClnZeroPln= string.Empty;
          this.CmdDisBoth= string.Empty;
          this.AttachPath= string.Empty;
          this.ConfigPath= string.Empty;
          this.WrkshtPath= string.Empty;
          this.ClsZoDiffR= string.Empty;
          this.ClsNoConfi= string.Empty;
          this.DTWPath= string.Empty;
          this.DfltByEml= string.Empty;
          this.INVOBPrice= string.Empty;
          this.SplitFBSh= string.Empty;
          this.NotifyRqr= string.Empty;
          this.DeactivFA= string.Empty;
          this.CshDctFA= string.Empty;
          this.SendAlert= string.Empty;
          this.BdgtPRQDOC= string.Empty;
          this.IsReuseNum= string.Empty;
          this.IsReuseNFN= string.Empty;
          this.SIPLReport= string.Empty;
          this.SIPLDoc= string.Empty;
          this.SIPLSeting= string.Empty;
          this.PriceProcM= string.Empty;
          this.ChkQtyINV= string.Empty;
          this.EnbAdvATP= string.Empty;
          this.EnblCase= string.Empty;
          this.EnbSupplC= string.Empty;
          this.MBAOnPer= string.Empty;
          this.MBAOnAP= string.Empty;
          this.MBAOnAR= string.Empty;
          this.ApyBsActSP= string.Empty;
          this.ApyBsActPV= string.Empty;
          this.ApyBsActPL= string.Empty;
          this.IsUpdNstdB= string.Empty;
          this.SnBDfltSB= string.Empty;
          this.OneBOneRec= string.Empty;
          this.ReptCurrcy= string.Empty;
          this.INCSingToV= string.Empty;
          this.POrCByINC= string.Empty;
          this.EnbNegPym= string.Empty;
          this.SirenNo= string.Empty;
          this.SEPACredID= string.Empty;
          this.InstitCode= string.Empty;
          this.ApyDRinPEC= string.Empty;
          this.ApyPRinPEC= string.Empty;
          this.TaxPyerSta= string.Empty;
          this.DftResWhs= string.Empty;
          this.AutoResWhs= string.Empty;
          this.InActRpt= string.Empty;
          this.InActMkt= string.Empty;
          this.InActPln= string.Empty;
          this.StartFrom= string.Empty;
          this.JEInFATran= string.Empty;
          this.TxtSrch= string.Empty;
          this.ApyIBtoACT= string.Empty;
          this.JeUnGroup= string.Empty;
          this.IgnoreAdde= string.Empty;
          this.EnterAsTab= string.Empty;
          this.MouseOnly= string.Empty;
          this.PrjMngmnt= string.Empty;
          this.ElectrDocs= string.Empty;
          this.DotAsSep= string.Empty;
          this.DoMngMth= string.Empty;
          this.AlwBPNOwn= string.Empty;
          this.EmptyPKL= string.Empty;
          this.ExcNInvItm= string.Empty;
          this.MultiSched= string.Empty;
          this.CloseWipV= string.Empty;
          this.EnbApUpDoc= string.Empty;
          this.EnbApUpDft= string.Empty;
          this.EnPacking= string.Empty;
          this.BlockZeroQ= string.Empty;
          this.NegStoLv= string.Empty;
          this.EnUpdBAPln= string.Empty;
          this.BAOpPOR= string.Empty;
          this.BAOpPDN= string.Empty;
          this.BAOpAcctng= string.Empty;
          this.AssgnOBAAP= string.Empty;
          this.AssngOBAAR= string.Empty;
          this.ApyToNewBP= string.Empty;
          this.PrrConfrmd= string.Empty;
          this.RrrConfrmd= string.Empty;
          this.EnblLC= string.Empty;
          this.DflAcct= string.Empty;
          this.SmtpServer= string.Empty;
          this.SmtpPort= string.Empty;
          this.SmtpName= string.Empty;
          this.SmtpPasswd= string.Empty;
          this.SmtpEncode= string.Empty;
          this.SmtpAuthen= string.Empty;
          this.TlsEncryp= string.Empty;
          this.HtmlDirect= string.Empty;
          this.IncSubject= string.Empty;
          this.TenLevel= string.Empty;
          this.AuImpRates= string.Empty;
          this.ValidateBa= string.Empty;
          this.ManRemark= string.Empty;
          this.ManRmkType= string.Empty;
          this.ManRmkAlt= string.Empty;
          this.TermsPath= string.Empty;
          this.DspBUoM= string.Empty;
          this.EDocSName= string.Empty;
          this.EDocSEMail= string.Empty;
          this.CpyRulToTx= string.Empty;
          this.BpNoLock= string.Empty;
          this.SearchUrl= string.Empty;
          this.EnableMTD= string.Empty;
          this.PublicComp= string.Empty;
          this.EnableEWB= string.Empty;
          this.EwbGenType= string.Empty;
          this.VolumeLic= string.Empty;
          this.DfSVatExG= string.Empty;
          this.DfSVatExL= string.Empty;
          this.EnUpdBpAdr= string.Empty;
          this.EnExtTax= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompnyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompnyAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrintHeadr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Phone1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Phone2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Fax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string E_Mail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Manager { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MainCurncy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SysCurrncy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DispPosDeb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DefLengthU { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DefWeightU { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltVendPM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DirectRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinAmnt347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoITW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCountr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxIdNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevOffice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeZoneNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DdctFileNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatCharge { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayOutVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpsitPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IncomeTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VendorDdct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CustmrDdct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DdctPercnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DdctExpire { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DdctOffice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EURepSqntl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BoxRptSeq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTLiable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltCustPM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AllowFuPos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseProdWip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CurrPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string XmlPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DflBnkKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BSInstled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseShpdGd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseExtRpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ERpPerType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfSVatExmp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfPVatExmp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Manager1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Manager1F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CCMask { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObligLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreditLimt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SalesLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DlnLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrderLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddDlnBlnc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreditDpst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MultiLang { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DbVers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ApplVers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflWebSite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflFTPSite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevisionPo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Reindex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DllPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxIdValid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PchName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RpcName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PdnName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RpdName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PorName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LevelWarn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdCommUse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmCommUse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SlpCommUse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DfCustTerm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DfVendTerm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SaleProfit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CostPrcLst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GrossBySal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TreePricOn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseFld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ClosedQuot { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SumDec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? QtyDec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PriceDec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RateDec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PercentDec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? MeasureDec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DdAutoRun { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DdNextDue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DdHour { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CmpnyAddrF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflTaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrintHdrF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Phone1F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Phone2F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FaxF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManagerF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TimeFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CigCup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DateFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DateSep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FcNoBlnc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChangeRdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MultiCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PickParDlv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxTaxIncr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ISRType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxTaxDecr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RoundRmrk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISRBillerI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UpdStamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SysCNoEdit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefDNoEdit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltWhs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxDNoEdit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfSVatItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfSVatServ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfPVatItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfPVatServ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DoBudget { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string CustIdNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BgtBlock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BgtWarning { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BdgtPORDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BdgtAcctng { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BdgtDflt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ContInvnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvntSystm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApplicIFRS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? StartYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? According { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MltpBrnchs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnblSrvTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DftRCN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RoundVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BdgtPDNDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IRSFileNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeferrTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DflIntrst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DfltSlp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DflCrCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflBnkCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflBnkAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflBranch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UsePaSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Serv_Usr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Serv_Pass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExcelPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxIdNum2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxIdNum3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DecSep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ThousSep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CurOnRight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WarnByWhs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DflBnkAcKy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriceSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DftPVL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string useDdctTrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string useDocWrf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BtchStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrderBatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GLMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SetSriUniq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SriUniqFld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MaxHistory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxRateDet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefreshQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StockNoBas { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MaxCntRows { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CentPmtInc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CentPmtOut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChCtrAPAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChCtrARAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PACUsrName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PACPasswrd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CaredType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PBSNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PBSGroupNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrgNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActSep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DspBokpWin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SHandleWT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SDfltWT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncresGlAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PHandleWT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PDfltWT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExWTLiabl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string free84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AllowPostZ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PostDiffR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnableRO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UalLastDel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UalKeepDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NegAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnbDocOpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HldCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AlphaDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocURL2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnPriceMod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaaSEnable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaaSUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrderBlock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RoundMthd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AdrsFromWH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrderParty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrtfcateNO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ExpireDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NINum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaaSPass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaaSAutURL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CfwAsnMust { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CfwInDflt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CfwOutDflt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaaSURL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaaSSaleAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxRegime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AliasName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DftJPELine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RdrConfrmd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PorConfrmd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaaSPurcAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AdvImagePr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ChfAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CEO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? WllPprDsp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WallPaper { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RndToTDec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SDfltITWT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PDfltITWT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckFiles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DsplyRates { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfActCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string defTaxVend { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RcrFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RclFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ContactLog { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowNewMsg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpenCdt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ConsumeFCT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ConsumeMtd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DaysBack { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DaysFwrd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsPAPrn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowNewTsk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCodeCst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCodeVnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CharMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string free83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ScreenLock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpenCredit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpenDps { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AltBOEPost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LDiscTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltDunTrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Profession { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? AlertPolFr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DfltCDP { get; set; }
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
        public string DflBCACode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IgrAllCash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxPayerRf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmployerRf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PStatAutCh { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PStatDelay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepBusType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepBusOthr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BrachNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BuisnesDsc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReptMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Bookpitype { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActSoftNam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpnClsRmrk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxRndRule { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NegTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ZeroLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GBOpenFile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GBIntface { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DfltCDPV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OnHldPert { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTRndRule { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GPPrcntSrv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DspFrznBP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DspFrznITM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTAccumAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NewDPRCus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ServNature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PickLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTAccAmtAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseProdPL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? QueryDec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExRtDefTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoletoPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? MMLastImpD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CpyExhRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MapService { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ODWFreq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GTSOutPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseMltDims { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MDStyle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GTSInPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GTSSep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? GTSDftChk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? GTSDftPye { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GTSMaxAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RspOverAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DRBlock1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DRBlock2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DRBlock3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DRBlock4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DRBlock5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrjBlock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SimReport { get; set; }
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
        public string BackOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HQLocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DigCrtPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DflWTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnbApprDI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChBPSerie { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChItmSerie { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ETRTaxOffi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ETRTaxPers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EDocExpFrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PCN874RTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BTWDecProv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BTWDcPrvID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BTWName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BTWStreet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BTWCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BTWZip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BTWPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BTWOB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BTWICP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BTWOBFmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BTWICPFmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ETRPhoneNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDTestMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocGenTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EDocRptFmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocPass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDProcess { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PAC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NotifAlert { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NotifEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EDocUDQCat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EOutputPth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EDelDocFrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EDocPmnFmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocURL1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ETRFaxNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ETRMgrPhn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EDFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AIDFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrtLineRFQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflJET { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OnlyPaidIn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PDDEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MaxDays4DD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoAddUoM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoAddPkg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinActivat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? IssuePriBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InstFixAst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeprecCalc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FixAstMod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SopPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NewAcctDe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ClnZeroPln { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CmdDisBoth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CnclMaxDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttachPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ConfigPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WrkshtPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ICDifExPe1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ICDifExPe2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ClsZoDiffR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ClsNoConfi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DTWPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltByEml { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreditDay1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string INVOBPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SplitFBSh { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NotifyRqr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeactivFA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CshDctFA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendAlert { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BdgtPRQDOC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsReuseNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsReuseNFN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SIPLReport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SIPLDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SIPLSeting { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriceProcM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChkQtyINV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnbAdvATP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnblCase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnbSupplC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MBAOnPer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MBAOnAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MBAOnAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApyBsActSP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApyBsActPV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApyBsActPL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsUpdNstdB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SnBDfltSB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OneBOneRec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReptCurrcy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ICDifExPe3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string INCSingToV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string POrCByINC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnbNegPym { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SirenNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SEPACredID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InstitCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ECDFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApyDRinPEC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApyPRinPEC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxPyerSta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MaxINVRptR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DftResWhs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoResWhs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InActRpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InActMkt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InActPln { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StartFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Months { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Days { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JEInFATran { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public short? TPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TxtSrch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApyIBtoACT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JeUnGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IgnoreAdde { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnterAsTab { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MouseOnly { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrjMngmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ElectrDocs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DotAsSep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DoMngMth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AlwBPNOwn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmptyPKL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExcNInvItm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PayRefCalc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MultiSched { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CloseWipV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? onHldLimt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnbApUpDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnbApUpDft { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnPacking { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockZeroQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NegStoLv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnUpdBAPln { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BAOpPOR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BAOpPDN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BAOpAcctng { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AssgnOBAAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AssngOBAAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApyToNewBP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrrConfrmd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RrrConfrmd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DflSeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnblLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SmtpServer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SmtpPort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SmtpName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SmtpPasswd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SmtpEncode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SmtpAuthen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TlsEncryp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HtmlDirect { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncSubject { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TenLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreditDay2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CdtPrvDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AuImpRates { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValidateBa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManRemark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManRmkType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManRmkAlt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TermsPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EDocWSFrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DspBUoM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocSName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocSEMail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CpyRulToTx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpNoLock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SearchUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnableMTD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Threshold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PublicComp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnableEWB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TspEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TspLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EwbGenType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VolumeLic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfSVatExG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfSVatExL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnUpdBpAdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnExtTax { get; set; }
    }
}