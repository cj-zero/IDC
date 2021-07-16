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
    public partial class GBI7 
    {
        public GBI7()
        {
          this.DocDate= string.Empty;
          this.DocType= string.Empty;
          this.JrnEntryNo= string.Empty;
          this.Remark= string.Empty;
          this.AcctNo= string.Empty;
          this.Currency= string.Empty;
          this.EvaGrp= string.Empty;
          this.SettMeth= string.Empty;
          this.BillType= string.Empty;
          this.BillNo= string.Empty;
          this.BillDate= string.Empty;
          this.Creator= string.Empty;
          this.Approver= string.Empty;
          this.Bookkeeper= string.Empty;
          this.Cashier= string.Empty;
          this.Posted= string.Empty;
          this.Reversed= string.Empty;
          this.DocNum= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JrnEntryNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LnNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Debit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Credit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FCDebit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FCCredit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UnitPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EvaGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SettMeth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BillType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BillNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BillDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? AttmtNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Creator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Approver { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Bookkeeper { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Cashier { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Posted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Reversed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocNum { get; set; }
    }
}