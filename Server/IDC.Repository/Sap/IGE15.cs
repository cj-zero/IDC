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
    public partial class IGE15 
    {
        public IGE15()
        {
          this.ObjType= string.Empty;
          this.VatGroup= string.Empty;
          this.StaCode= string.Empty;
          this.TaxCode= string.Empty;
          this.LineType= string.Empty;
          this.IsPrscGood= string.Empty;
          this.IsCstmAct= string.Empty;
        }

        
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
        public string VatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StaCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StaType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StaIndex { get; set; }
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
        public decimal? VatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSumFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSumSc { get; set; }
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
        public decimal? PaidNet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidNetFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidNetSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidVatFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidVatSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidDct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidDctFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidDctSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidEq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidEqFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidEqSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplNet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplNetF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplNetS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplVatF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplVatS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplDct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplDctF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplDctS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplEq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplEqFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplEqSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseGrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseGrsFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseGrsSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplGrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplGrsFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplGrsSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidGrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidGrsFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidGrsSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplGrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplGrsF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplGrsS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsChrgSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsChrgSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsChrgFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplRvs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplRvsSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplRvsFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidRvs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidRvsSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidRvsFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplRvs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplRvsS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpApplRvsF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsPrscGood { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsCstmAct { get; set; }
    }
}