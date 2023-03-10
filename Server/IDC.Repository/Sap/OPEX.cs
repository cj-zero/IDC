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
    public partial class OPEX 
    {
        public OPEX()
        {
          this.PayRunDate= DateTime.Now;
          this.VendorNum= string.Empty;
          this.CustNum= string.Empty;
          this.PaymMethod= string.Empty;
          this.FiscalYear= DateTime.Now;
          this.Country= string.Empty;
          this.CompTaxNum= string.Empty;
          this.PayeeName= string.Empty;
          this.PayeeZip= string.Empty;
          this.PayeeCity= string.Empty;
          this.PayeeStree= string.Empty;
          this.PayCountry= string.Empty;
          this.PayeeState= string.Empty;
          this.PayBnkName= string.Empty;
          this.PayBankZip= string.Empty;
          this.PayBnkCity= string.Empty;
          this.PayBnkStr= string.Empty;
          this.PayBnkCntr= string.Empty;
          this.PayBankAct= string.Empty;
          this.PayBnkCode= string.Empty;
          this.PayBnkCtrl= string.Empty;
          this.PayBnkSwif= string.Empty;
          this.PayBnkIBAN= string.Empty;
          this.PymPostDat= DateTime.Now;
          this.PymBnkAcct= string.Empty;
          this.PymBnkCntr= string.Empty;
          this.PymBnkCode= string.Empty;
          this.PymBnkIBAN= string.Empty;
          this.PymGLAcct= string.Empty;
          this.Currency= string.Empty;
          this.PymDocCurr= string.Empty;
          this.Status= string.Empty;
          this.InstrucKey= string.Empty;
          this.CllctAutho= string.Empty;
          this.PayBnkPost= string.Empty;
          this.PayBnkHsBk= string.Empty;
          this.PayBnkBlck= string.Empty;
          this.PayBnkCnty= string.Empty;
          this.PayBnkStat= string.Empty;
          this.PayBnkBISR= string.Empty;
          this.PayBnkUsr1= string.Empty;
          this.PayBnkUsr2= string.Empty;
          this.PayBnkUsr3= string.Empty;
          this.PayBnkUsr4= string.Empty;
          this.PaymFormat= string.Empty;
          this.CompName= string.Empty;
          this.CompAddres= string.Empty;
          this.CompISRBil= string.Empty;
          this.VendISRBil= string.Empty;
          this.AddIdNum= string.Empty;
          this.CompOrgNum= string.Empty;
          this.PayBnkBrnc= string.Empty;
          this.PymBnkBrnc= string.Empty;
          this.UserName= string.Empty;
          this.UserEmail= string.Empty;
          this.UserPortNo= string.Empty;
          this.UserFax= string.Empty;
          this.DebitMemo= string.Empty;
          this.EuInTrnsfr= string.Empty;
          this.FilePath= string.Empty;
          this.OrderParty= string.Empty;
          this.PymCtrlKey= string.Empty;
          this.PayeeTaxNo= string.Empty;
          this.PymKeyCode= string.Empty;
          this.PayRefDtls= string.Empty;
          this.FormatName= string.Empty;
          this.CheckPmnt= string.Empty;
          this.PymBnkUsr1= string.Empty;
          this.PymBnkUsr2= string.Empty;
          this.PymBnkUsr3= string.Empty;
          this.PymBnkUsr4= string.Empty;
          this.CompStreet= string.Empty;
          this.CompBlock= string.Empty;
          this.CompCity= string.Empty;
          this.CompZip= string.Empty;
          this.CompCounty= string.Empty;
          this.CompState= string.Empty;
          this.PymBCACode= string.Empty;
          this.PaymDocTyp= string.Empty;
          this.FreeText1= string.Empty;
          this.FreeText2= string.Empty;
          this.FreeText3= string.Empty;
          this.PymBnkSwif= string.Empty;
          this.PayBnkUIC= string.Empty;
          this.LineType= string.Empty;
          this.BoeCurrSta= string.Empty;
          this.BoeDate= DateTime.Now;
          this.BoeDueDate= DateTime.Now;
          this.Instruct1= string.Empty;
          this.Instruct2= string.Empty;
          this.BoeCancIns= string.Empty;
          this.BoeOccCode= string.Empty;
          this.BoePtfID= string.Empty;
          this.BoeDiscD= DateTime.Now;
          this.BoeFineD= DateTime.Now;
          this.BoeIntrstD= DateTime.Now;
          this.BoeMovCode= string.Empty;
          this.BarcodeRep= string.Empty;
          this.PaPriority= string.Empty;
          this.PaymType= string.Empty;
          this.RecipStatu= string.Empty;
          this.BudegetId= string.Empty;
          this.OKATO= string.Empty;
          this.PymReason= string.Empty;
          this.PostPeriod= string.Empty;
          this.BaseDocTyp= string.Empty;
          this.BaseDocDat= DateTime.Now;
          this.TaxPymType= string.Empty;
          this.OKTMO= string.Empty;
          this.SeqType= string.Empty;
          this.PymDate= DateTime.Now;
          this.PymBnkName= string.Empty;
          this.UIPCode= string.Empty;
          this.SpltPmtVAT= string.Empty;
          this.EnBnkAct= string.Empty;
          this.EnBnkIBan= string.Empty;
          this.EncryptIV= string.Empty;
          this.DPPStatus= string.Empty;
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
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompTaxNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayeeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayeeZip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayeeCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayeeStree { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayCountry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayeeState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBankZip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkCntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBankAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkCtrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkSwif { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkIBAN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PymPostDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymBnkAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymBnkCntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymBnkCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymBnkIBAN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymGLAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PymDocAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymDocCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PymDcAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PymCshDsct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PyCshDscFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PymNumOfPa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PymDocRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PaymWizCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InstrucKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CllctAutho { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkPost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PayBnkChNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkHsBk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkBlck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkCnty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkStat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkBISR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkUsr1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkUsr2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkUsr3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkUsr4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaymFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompAddres { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompISRBil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VendISRBil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string AddIdNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompOrgNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkBrnc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymBnkBrnc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserPortNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserFax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Department { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DebitMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EuInTrnsfr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FilePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrderParty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymCtrlKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayeeTaxNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymKeyCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayRefDtls { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FormatName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckPmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymBnkUsr1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymBnkUsr2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymBnkUsr3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymBnkUsr4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompStreet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompBlock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompZip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompCounty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymBCACode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaymDocTyp { get; set; }
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
        public string PymBnkSwif { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayBnkUIC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BoeKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeCurrSta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BoeDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BoeDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Instruct1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Instruct2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeCancIns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeOccCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoePtfID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BoeOurNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BoeIntrAm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BoeDiscD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BoeDisAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BoeFineD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BoeFineAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BoeIntrstD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BoeIOFAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeMovCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BarcodeRep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PONumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? POSeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaPriority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaymType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RecipStatu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string BudegetId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OKATO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymReason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PostPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseDocTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BaseDocDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxPymType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OKTMO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeqType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PymDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymBnkName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UIPCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public short? UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpltPmtVAT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnBnkAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnBnkIBan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPPStatus { get; set; }
    }
}