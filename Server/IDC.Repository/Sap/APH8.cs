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
    public partial class APH8 
    {
        public APH8()
        {
          this.DueDate= DateTime.Now;
          this.CloseDate= DateTime.Now;
          this.Valid= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PhBudget { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenAmtAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InvoicedAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotVarAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VarPercAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccPhBudg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccOpAmAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccInvAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccTotAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccTVarAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccVPercAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PoPhAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenAmtAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InvoicedAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotVarAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VarPercAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccPoPhAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccOpAmAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccInvAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccTotAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccTVarAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccVPercAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ActICCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ActRCCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ActAddCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ActPrCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ActBPrCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalVar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CloseDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Overdue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Valid { get; set; }
    }
}