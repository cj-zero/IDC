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
    public partial class OGTM 
    {
        public OGTM()
        {
          this.CreateDate= DateTime.Now;
          this.GtsMapNum= string.Empty;
          this.BpCode= string.Empty;
          this.BpName= string.Empty;
          this.BpTaxRegNo= string.Empty;
          this.BpAddrTel= string.Empty;
          this.BpBankNum= string.Empty;
          this.Remark= string.Empty;
          this.Checker= string.Empty;
          this.Payee= string.Empty;
          this.GtsStatus= string.Empty;
          this.ExportDate= DateTime.Now;
          this.VoidDate= DateTime.Now;
          this.ImportDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GtsMapNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InvMapEnty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? GtsInvNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpTaxRegNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpAddrTel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpBankNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Checker { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Payee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmtAftDsct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GtsStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ExportDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? VoidDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ImportDate { get; set; }
    }
}