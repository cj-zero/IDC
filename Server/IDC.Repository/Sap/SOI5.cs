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
    public partial class SOI5 
    {
        public SOI5()
        {
          this.SOILineNum= 0;
          this.ItemCode= string.Empty;
          this.ItemName= string.Empty;
          this.unitMsr= string.Empty;
          this.Currency= string.Empty;
          this.BasNumAtCr= string.Empty;
          this.BasTaxDate= DateTime.Now;
          this.TaxCtgr= string.Empty;
          this.VatGroup= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int SOILineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string unitMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalFrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BasNumAtCr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BasTaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FExcBasSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AExcBasSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExciseUoM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExcRateUoM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExcRateAdV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExciseSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatBaseSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCtgr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGroup { get; set; }
    }
}