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
    public partial class OGTI 
    {
        public OGTI()
        {
          this.CreateDate= DateTime.Now;
          this.MappingNum= string.Empty;
          this.Voiding= string.Empty;
          this.ItemList= string.Empty;
          this.CategNum= string.Empty;
          this.GtsInvNum= string.Empty;
          this.DocDate= DateTime.Now;
          this.BpName= string.Empty;
          this.BpTaxRgNum= string.Empty;
          this.BpAddrTel= string.Empty;
          this.BpBankNum= string.Empty;
          this.SellerName= string.Empty;
          this.SelTaxReg= string.Empty;
          this.SelAddTel= string.Empty;
          this.SelBankAct= string.Empty;
          this.Remarks= string.Empty;
          this.Issuer= string.Empty;
          this.Checker= string.Empty;
          this.Payee= string.Empty;
          this.InBndFile= string.Empty;
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
        public string MappingNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Voiding { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CategNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GtsInvNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ItemRowNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FiscaMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpTaxRgNum { get; set; }
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
        public string SellerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SelTaxReg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SelAddTel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SelBankAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Issuer { get; set; }
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
        public string InBndFile { get; set; }
    }
}