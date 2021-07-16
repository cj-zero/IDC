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
    public partial class RTW1 
    {
        public RTW1()
        {
          this.BoeMatch= string.Empty;
          this.BoeNo= string.Empty;
          this.BoeDate= DateTime.Now;
          this.BoeDueDate= DateTime.Now;
          this.CreditDate= DateTime.Now;
          this.CurrBoeSt= string.Empty;
          this.ReqBoeSt= string.Empty;
          this.Instruct1= string.Empty;
          this.Instruct2= string.Empty;
          this.CancelCode= string.Empty;
          this.OccurDate= DateTime.Now;
          this.Portfolio= string.Empty;
          this.Errors= string.Empty;
          this.RefNum= string.Empty;
          this.Ref2= string.Empty;
          this.CardName= string.Empty;
          this.BoEBPName= string.Empty;
          this.MatchCode= string.Empty;
          this.Selected= string.Empty;
          this.Filtered= string.Empty;
          this.Executed= string.Empty;
          this.Failed= string.Empty;
          this.LastRun= string.Empty;
          this.ErrorMsg= string.Empty;
          this.JETransId= string.Empty;
          this.CardCode= string.Empty;
          this.PostType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeMatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BoeDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BoeDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreditDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CurrBoeSt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReqBoeSt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Instruct1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Instruct2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CancelCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? MovmntCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? OccurCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? OccurDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Portfolio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OurNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ValueOfT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NetAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FineAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IntAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Discounts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ServiceFee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IOFTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OtherCred { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OtherExp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OtherInc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Errors { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoEBPName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MatchCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Selected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BoeRec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RetIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Filtered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Executed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Failed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LastRun { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ErrorMsg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string JETransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PostType { get; set; }
    }
}