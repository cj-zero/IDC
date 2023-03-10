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
    public partial class OECDW 
    {
        public OECDW()
        {
          this.RunName= string.Empty;
          this.RunDate= DateTime.Now;
          this.Status= string.Empty;
          this.DateFrom= DateTime.Now;
          this.DateTo= DateTime.Now;
          this.DecenInd= string.Empty;
          this.InstCode= string.Empty;
          this.EntIdCode= string.Empty;
          this.SituatInd= string.Empty;
          this.ReportType= string.Empty;
          this.CmpName= string.Empty;
          this.CmpState= string.Empty;
          this.CmpCntCode= string.Empty;
          this.CmpCNPJ= string.Empty;
          this.CmpIE= string.Empty;
          this.CmpCity= string.Empty;
          this.BrnState= string.Empty;
          this.BrnCntCode= string.Empty;
          this.BrnCNPJ= string.Empty;
          this.BrnIE= string.Empty;
          this.BrnCity= string.Empty;
          this.AccStIden= string.Empty;
          this.AccStRem= string.Empty;
          this.BookPurp= string.Empty;
          this.PeriodSitu= string.Empty;
          this.BkPrpsInd= string.Empty;
          this.NIREind= string.Empty;
          this.SubBkNIRE= string.Empty;
          this.SubBkHash= string.Empty;
          this.BalanRefF= string.Empty;
          this.BalanUdfF= string.Empty;
          this.PrLosRefF= string.Empty;
          this.PrLosUdfF= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RunName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RunDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RunTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DecenInd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Branch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InstCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string EntIdCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SituatInd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReportType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CmpName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CmpState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CmpCntCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CmpCNPJ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CmpIE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CmpCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BrnState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BrnCntCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BrnCNPJ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BrnIE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BrnCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string AccStIden { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AccStRem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BookPurp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? JrnlNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PeriodSitu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BkPrpsInd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NIREind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubBkNIRE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubBkHash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BalanTemp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PrLosTemp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BalanRefF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BalanUdfF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrLosRefF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrLosUdfF { get; set; }
    }
}