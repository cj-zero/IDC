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
    public partial class AVTG 
    {
        public AVTG()
        {
          this.Name= string.Empty;
          this.EffecDate= DateTime.Now;
          this.Category= string.Empty;
          this.Account= string.Empty;
          this.Locked= string.Empty;
          this.DataSource= string.Empty;
          this.IsEC= string.Empty;
          this.Indicator= string.Empty;
          this.AcqstnRvrs= string.Empty;
          this.AcqsTax= string.Empty;
          this.GoddsShip= string.Empty;
          this.NonDedAcc= string.Empty;
          this.DeferrAcc= string.Empty;
          this.ReportCode= string.Empty;
          this.FixdAssts= string.Empty;
          this.CalcMethod= string.Empty;
          this.TaxType= string.Empty;
          this.ExtCode= string.Empty;
          this.Correction= string.Empty;
          this.VatCrctn= string.Empty;
          this.RetVatCode= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.TaxCtgr= string.Empty;
          this.EquAccount= string.Empty;
          this.IsIGIC= string.Empty;
          this.ServSupply= string.Empty;
          this.Inactive= string.Empty;
          this.TaxCtgrBL= string.Empty;
          this.VatRevAcc= string.Empty;
          this.CashDisAcc= string.Empty;
          this.DpmTaxOAcc= string.Empty;
          this.VatDedAcc= string.Empty;
          this.CstmExpAcc= string.Empty;
          this.CstmAlcAcc= string.Empty;
          this.TaxRegion= string.Empty;
          this.ExemReason= string.Empty;
          this.Agent= string.Empty;
          this.OpCode= string.Empty;
          this.Export= string.Empty;
          this.Section= string.Empty;
          this.SplitPaymt= string.Empty;
          this.SplitPayAc= string.Empty;
          this.TaxAgent= string.Empty;
          this.SectionLim= string.Empty;
          this.VatSubjCod= string.Empty;
          this.Parag44= string.Empty;
          this.ProrataDed= string.Empty;
          this.ExcFrmTaxS= string.Empty;
          this.CstmActing= string.Empty;
          this.CstmActOut= string.Empty;
          this.StdTaxCode= string.Empty;
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
        public System.DateTime? EffecDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Account { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsEC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Indicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcqstnRvrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NonDedct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcqsTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GoddsShip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NonDedAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeferrAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EquVatPr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReportCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FixdAssts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CalcMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FixedAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Correction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatCrctn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RetVatCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RepType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCtgr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EquAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsIGIC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ServSupply { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Inactive { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCtgrBL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? R349Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatRevAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CashDisAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpmTaxOAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatDedAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstmExpAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstmAlcAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxRegion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExemReason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Agent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Export { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Section { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SplitPaymt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SplitPayAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxAgent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SectionLim { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatSubjCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VatType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VatCategor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Parag44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProrataDed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExcFrmTaxS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstmActing { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstmActOut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StdTaxCode { get; set; }
    }
}