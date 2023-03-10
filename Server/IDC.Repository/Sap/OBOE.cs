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
    public partial class OBOE 
    {
        public OBOE()
        {
          this.BoeNum= 0;
          this.BoeStatus= string.Empty;
          this.BoeType= string.Empty;
          this.DpsBankCod= string.Empty;
          this.DpsCntrCod= string.Empty;
          this.DueDate= DateTime.Now;
          this.DpstAcct= string.Empty;
          this.DpstBranch= string.Empty;
          this.Details= string.Empty;
          this.TransRef= string.Empty;
          this.PmntDate= DateTime.Now;
          this.CardCode= string.Empty;
          this.CardName= string.Empty;
          this.BoeAcct= string.Empty;
          this.Currency= string.Empty;
          this.Printed= string.Empty;
          this.TotalWords= string.Empty;
          this.Signature= string.Empty;
          this.Address= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.VatCalcult= string.Empty;
          this.TaxDate= DateTime.Now;
          this.DataSource= string.Empty;
          this.Transfered= string.Empty;
          this.BPBankCod= string.Empty;
          this.BPBankNam= string.Empty;
          this.BPBankAct= string.Empty;
          this.BPBankBrnc= string.Empty;
          this.BPBankCtr= string.Empty;
          this.RefNum= string.Empty;
          this.IsReconcld= string.Empty;
          this.Comments= string.Empty;
          this.PayMethCod= string.Empty;
          this.PymMethNam= string.Empty;
          this.ControlKey= string.Empty;
          this.AgentCode= string.Empty;
          this.DepositTyp= string.Empty;
          this.CreatStatu= string.Empty;
          this.Ref2= string.Empty;
          this.PayEngSt1= string.Empty;
          this.PayEngSt2= string.Empty;
          this.PayEngSt3= string.Empty;
          this.StampTax= string.Empty;
          this.Portfolio= string.Empty;
          this.VndCodeCEE= string.Empty;
          this.VndNameCEE= string.Empty;
          this.BarcodeNum= string.Empty;
          this.BarcodeRep= string.Empty;
          this.OurNumChk= string.Empty;
          this.FolioPref= string.Empty;
          this.IntrstDate= DateTime.Now;
          this.DiscDate= DateTime.Now;
          this.FineDate= DateTime.Now;
          this.PostType= string.Empty;
          this.EnBPBnkAct= string.Empty;
          this.EncryptIV= string.Empty;
          this.DPPStatus= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int BoeNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpsBankCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpsCntrCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpstAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpstBranch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Details { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PmntDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PmntNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BoeSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BoeSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BoeSumFC { get; set; }
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
        public string BoeAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Printed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TotalWords { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Signature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LinesSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DdctPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatTotalSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatTotalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatCalcult { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumRfndCln { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PrintedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Instance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPBankCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPBankNam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPBankAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPBankBrnc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPBankCtr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsReconcld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayMethCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DepositNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymMethNam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DeductSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ControlKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AgentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ReconcilNu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DepositTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreatStatu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayEngSt1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayEngSt2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayEngSt3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StampTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StmpTxAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DpsActKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OutBnkKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Portfolio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VndCodeCEE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VndNameCEE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OurNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BarcodeNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BarcodeRep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OurNumChk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FolioPref { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FolioNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LPgFolioN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IntrstAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DiscAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FineAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? IntrstDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DiscDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FineDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PostType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IOFAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ServFeeAm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OtherExAm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OtherInAm { get; set; }
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
        public string EnBPBnkAct { get; set; }
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