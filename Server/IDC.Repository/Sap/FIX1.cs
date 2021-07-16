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
    public partial class FIX1 
    {
        public FIX1()
        {
          this.ItemCode= string.Empty;
          this.DprArea= string.Empty;
          this.PeriodCat= string.Empty;
          this.RefDate= DateTime.Now;
          this.SpDprKey1= string.Empty;
          this.DprType= string.Empty;
          this.DprDate= DateTime.Now;
          this.RecvAsst= string.Empty;
          this.RetirDate= DateTime.Now;
          this.SpDprKey2= string.Empty;
          this.SpDprKey3= string.Empty;
          this.TransType= string.Empty;
          this.NewAstCls= string.Empty;
          this.Remark= string.Empty;
          this.ReTranType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DprArea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PeriodCat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PostPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? APC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrdDpr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UnpDpr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpDprKey1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SpDpr1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Qty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DprType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DprDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RemLife { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SalvageVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RecvAsst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RetirDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpDprKey2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SpDpr2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpDprKey3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UsefulLife { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Appr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WriteUp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DeltaDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NewAstCls { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? HistOrdDpr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SpDpr3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TransAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReTranType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NewTtlUnit { get; set; }
    }
}