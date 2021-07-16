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
    public partial class OSTA 
    {
        public OSTA()
        {
          this.Name= string.Empty;
          this.SalesTax= string.Empty;
          this.UseTax= string.Empty;
          this.PurchTax= string.Empty;
          this.deferrAcct= string.Empty;
          this.NonDdctAct= string.Empty;
          this.TaxInPrice= string.Empty;
          this.Exempt= string.Empty;
          this.APExpAct= string.Empty;
          this.ARExpAct= string.Empty;
          this.InGrossRev= string.Empty;
          this.EfctDate= DateTime.Now;
          this.UnencumTax= string.Empty;
          this.TaxOnRI= string.Empty;
          this.DIOTRptTyp= string.Empty;
          this.IsSystem= string.Empty;
          this.InFirstIns= string.Empty;
          this.SaleTaxRCM= string.Empty;
          this.SaleRCMClr= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SalesTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurchTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string deferrAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NonDdctPrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NonDdctAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxInPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Exempt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string APExpAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARExpAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CredBala { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CredFG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CredCG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InGrossRev { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EfctDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SvcTaxCr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FlatAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TextCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UnencumTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxOnRI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DIOTRptTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsSystem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsCrgPrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InFirstIns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SaleTaxRCM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SaleRCMClr { get; set; }
    }
}