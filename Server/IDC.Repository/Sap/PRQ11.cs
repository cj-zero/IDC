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
    public partial class PRQ11 
    {
        public PRQ11()
        {
          this.VatGroup= string.Empty;
          this.ObjType= string.Empty;
          this.IsAcq= string.Empty;
          this.IsAllDrawn= string.Empty;
          this.IsGross= string.Empty;
          this.LineType= string.Empty;
          this.TaxCode= string.Empty;
          this.TaxAdjust= string.Empty;
          this.IsCstmAct= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalFrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSumFrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSumSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsAcq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsAllDrawn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsGross { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Gross { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrossFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrossSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplNet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplNetFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplNetSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplVatFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplVatSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseNet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseNetFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseNetSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseVatFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseVatSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseGross { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseGrossF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseGrossS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DctSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DctSumFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DctSumSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EqSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EqSumFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EqSumSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplDct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplDctFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplDctSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplEq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplEqFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplEqSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseDct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseDctFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseDctSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseEq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseEqFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseEqSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplGross { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplGrossF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplGrossS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxAdjust { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsChrgSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsChrgFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsChrgSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BasRvsChrg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BasRvsFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BasRvsSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplRvs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplRvsFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplRvsSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsCstmAct { get; set; }
    }
}