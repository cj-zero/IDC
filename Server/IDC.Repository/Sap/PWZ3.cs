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
    public partial class PWZ3 
    {
        public PWZ3()
        {
          this.CardCode= string.Empty;
          this.CardName= string.Empty;
          this.PymMeth= string.Empty;
          this.GLAccCode= string.Empty;
          this.GLAccName= string.Empty;
          this.PostDate= DateTime.Now;
          this.ValDate= DateTime.Now;
          this.CardType= string.Empty;
          this.Country= string.Empty;
          this.ObjType= string.Empty;
          this.PymBnkTrns= string.Empty;
          this.ActFrmtCod= string.Empty;
          this.Checked= string.Empty;
          this.FatherLine= string.Empty;
          this.InvCurr= string.Empty;
          this.IsTax= string.Empty;
          this.IsFreight= string.Empty;
          this.IsOrigMeth= string.Empty;
          this.IsrRef= string.Empty;
          this.Agent= string.Empty;
          this.NumAtCard= string.Empty;
          this.DpmPosted= string.Empty;
          this.Status= string.Empty;
          this.PayToCode= string.Empty;
          this.PayToCntr= string.Empty;
          this.PayToBank= string.Empty;
          this.PayToAct= string.Empty;
          this.PymCurr= string.Empty;
          this.OcrCode= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.PymDate= DateTime.Now;
          this.PrjCode= string.Empty;
          this.BcgVatGrp= string.Empty;
          this.LinePrjCod= string.Empty;
          this.LineType= string.Empty;
          this.Ref1= string.Empty;
          this.Ref2= string.Empty;
          this.Ref3= string.Empty;
          this.OrdrStatus= string.Empty;
          this.BnkCode= string.Empty;
          this.BnkAccNo= string.Empty;
          this.Branch= string.Empty;
          this.BnkCountr= string.Empty;
          this.TBankCode= string.Empty;
          this.TDflAccoun= string.Empty;
          this.TBankCount= string.Empty;
          this.TargetBran= string.Empty;
          this.DscDueDate= DateTime.Now;
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
          this.OriPymMeth= string.Empty;
          this.PymMethTyp= string.Empty;
          this.SinglePym= string.Empty;
          this.MandateID= string.Empty;
          this.SeqType= string.Empty;
          this.BaseDocDat= DateTime.Now;
          this.OKATO= string.Empty;
          this.PostPeriod= string.Empty;
          this.RecipStatu= string.Empty;
          this.BudgetId= string.Empty;
          this.PymReason= string.Empty;
          this.BaseDocTyp= string.Empty;
          this.TaxPymType= string.Empty;
          this.OKTMO= string.Empty;
          this.PymIsUpdat= string.Empty;
          this.OriPymCode= string.Empty;
          this.OriPymType= string.Empty;
          this.OriActCode= string.Empty;
          this.OriActName= string.Empty;
          this.OriFormat= string.Empty;
          this.WtIsPym= string.Empty;
          this.IBAN= string.Empty;
          this.SwiftNum= string.Empty;
          this.UIPCode= string.Empty;
          this.ExeByServ= string.Empty;
          this.SpltPmtVAT= string.Empty;
          this.EnPayToAct= string.Empty;
          this.EncryptIV= string.Empty;
          this.DPPStatus= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymMeth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GLAccCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GLAccName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PymAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PymAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PymAmnSyst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InvKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalLoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DueBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DueBalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DueBalSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DiscPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DiscSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DiscSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DiscSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PayAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PayAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PayAmntSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InvPayAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InvPayAmFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InvPayAmSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymBnkTrns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActFrmtCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Checked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FatherLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BfDcntSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BfNetDcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? vatApplied { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsFreight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsOrigMeth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FreightSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsrRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RoundSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Agent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public short? InstId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BoeNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NumAtCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DeductPer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpmPosted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumOfCheck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumFrstChk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumNxtChk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayToCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayToCntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayToBank { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayToAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExpSu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Line_ID { get; set; }
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
        public System.DateTime? PymDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgTaxSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgTaxSumF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgTaxSumS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrjCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BcgVatGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinePrjCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgPmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgPmntFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgPmntSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PayOrderNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ManualNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrdrStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BnkCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BnkAccNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Branch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BnkCountr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TBankCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TDflAccoun { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TBankCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TargetBran { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DscDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CIG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CUP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeCurrSta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BoeKey { get; set; }
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
        [Browsable(false)]
        public int? BPLId { get; set; }
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
        public string OriPymMeth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymMethTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SinglePym { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MandateID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeqType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BaseDocDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OKATO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PostPeriod { get; set; }
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
        public string BudgetId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymReason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseDocTyp { get; set; }
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
        public string PymIsUpdat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OriPymCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OriPymType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ReasonCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OriActCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OriActName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ReasonLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OriFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WtIsPym { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IBAN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SwiftNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UIPCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AgrNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExeByServ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpltPmtVAT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnPayToAct { get; set; }
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