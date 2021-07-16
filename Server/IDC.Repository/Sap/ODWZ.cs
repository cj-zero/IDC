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
    public partial class ODWZ 
    {
        public ODWZ()
        {
          this.WizardName= string.Empty;
          this.ToPayDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.Status= string.Empty;
          this.DunLevel= string.Empty;
          this.CreditZero= string.Empty;
          this.PayNoBased= string.Empty;
          this.CrdtNBased= string.Empty;
          this.DunTime= string.Empty;
          this.FromDate= DateTime.Now;
          this.ToDate= DateTime.Now;
          this.ManualJEs= string.Empty;
          this.DspOpnItms= string.Empty;
          this.AllowNegLt= string.Empty;
          this.DunTerm= string.Empty;
          this.FrmDueDate= DateTime.Now;
          this.ToDueDate= DateTime.Now;
          this.UpToDate= DateTime.Now;
          this.InvPostDat= DateTime.Now;
          this.InvDueDate= DateTime.Now;
          this.InvDocDate= DateTime.Now;
          this.Project= string.Empty;
          this.OcrCode= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.InVatGroup= string.Empty;
          this.InTaxCode= string.Empty;
          this.FeVatGroup= string.Empty;
          this.FeTaxCode= string.Empty;
          this.AutoRmk= string.Empty;
          this.Remarks= string.Empty;
          this.VersionNum= string.Empty;
          this.OvrDueOnly= string.Empty;
          this.QuickDisp= string.Empty;
          this.OPNoBased= string.Empty;
          this.CnsdVendor= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WizardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToPayDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DunLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreditZero { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayNoBased { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdtNBased { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DunTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FromDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManualJEs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DspOpnItms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AllowNegLt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DunTerm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FrmDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? InvPostDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? InvDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? InvDocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InVatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InTaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FeVatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FeTaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoRmk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? BPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LocCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VersionNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OvrDueOnly { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QuickDisp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OPNoBased { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CnsdVendor { get; set; }
    }
}