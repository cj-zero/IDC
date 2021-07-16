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
    public partial class PWZ4 
    {
        public PWZ4()
        {
          this.CardCode= string.Empty;
          this.CardName= string.Empty;
          this.PymMeth= string.Empty;
          this.GLAccCode= string.Empty;
          this.DocCurr= string.Empty;
          this.BankAccou= string.Empty;
          this.BnkDflt= string.Empty;
          this.BankCountr= string.Empty;
          this.LineType= string.Empty;
          this.TBankCode= string.Empty;
          this.TDflAccoun= string.Empty;
          this.TBankCount= string.Empty;
          this.TargetBran= string.Empty;
          this.RecipStatu= string.Empty;
          this.BudgetId= string.Empty;
          this.OKATO= string.Empty;
          this.PymReason= string.Empty;
          this.PostPeriod= string.Empty;
          this.BaseDocTyp= string.Empty;
          this.BaseDocDat= DateTime.Now;
          this.TaxPymType= string.Empty;
          this.OKTMO= string.Empty;
          this.IBAN= string.Empty;
          this.SwiftNum= string.Empty;
          this.UIPCode= string.Empty;
          this.DPPStatus= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PymNum { get; set; }
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
        public string DocCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankAccou { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BnkDflt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCountr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BankActKey { get; set; }
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
        public string DPPStatus { get; set; }
    }
}