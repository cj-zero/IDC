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
    public partial class OCHH 
    {
        public OCHH()
        {
          this.BankCode= string.Empty;
          this.Branch= string.Empty;
          this.CashCheck= string.Empty;
          this.CheckDate= DateTime.Now;
          this.Details= string.Empty;
          this.CardCode= string.Empty;
          this.RcptDate= DateTime.Now;
          this.Trnsfrable= string.Empty;
          this.Deposited= string.Empty;
          this.Converted= string.Empty;
          this.Vendor= string.Empty;
          this.BankAcct= string.Empty;
          this.AcctNum= string.Empty;
          this.Currency= string.Empty;
          this.Canceled= string.Empty;
          this.Transfered= string.Empty;
          this.BankCountr= string.Empty;
          this.Project= string.Empty;
          this.CardName= string.Empty;
          this.FiscalID= string.Empty;
          this.OrigIssdBy= string.Empty;
          this.RejeByBank= string.Empty;
          this.EnAcctNum= string.Empty;
          this.EncryptIV= string.Empty;
          this.DPPStatus= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CheckNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Branch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CashCheck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CheckDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Details { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RcptDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RcptNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CheckSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Trnsfrable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Deposited { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Converted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Vendor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DepNum2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DpstAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Canceled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? RcptLineId { get; set; }
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
        public short? UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCountr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CanceJEAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TempJEAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FiscalID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrigIssdBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RejeByBank { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnAcctNum { get; set; }
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