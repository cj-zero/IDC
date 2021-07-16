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
    public partial class ARC1 
    {
        public ARC1()
        {
          this.DueDate= DateTime.Now;
          this.BankCode= string.Empty;
          this.Branch= string.Empty;
          this.AcctNum= string.Empty;
          this.Details= string.Empty;
          this.Trnsfrable= string.Empty;
          this.Currency= string.Empty;
          this.CountryCod= string.Empty;
          this.CheckAct= string.Empty;
          this.ManualChk= string.Empty;
          this.FiscalID= string.Empty;
          this.OrigIssdBy= string.Empty;
          this.Endorse= string.Empty;
          this.EnAcctNum= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
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
        public string AcctNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Details { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Trnsfrable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CheckSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Flags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CountryCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CheckAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BnkActKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManualChk { get; set; }
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
        public string Endorse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EndorsChNo { get; set; }
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
    }
}