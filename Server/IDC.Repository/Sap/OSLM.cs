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
    public partial class OSLM 
    {
        public OSLM()
        {
          this.DocDate= DateTime.Now;
          this.Status= string.Empty;
          this.DateFrom= DateTime.Now;
          this.DateTo= DateTime.Now;
          this.RateType= string.Empty;
          this.Comment= string.Empty;
          this.Canceled= string.Empty;
          this.CancelDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Ref1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Ref2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
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
        public decimal? TotDebit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotCredit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RateType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Canceled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CancelDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CancelUser { get; set; }
    }
}