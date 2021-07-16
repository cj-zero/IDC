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
    public partial class OHSV 
    {
        public OHSV()
        {
          this.Ref1= string.Empty;
          this.Ref2= string.Empty;
          this.RefDate= string.Empty;
          this.DueDate= string.Empty;
          this.CurrCode= string.Empty;
          this.Memo= string.Empty;
          this.DebAcct1= string.Empty;
          this.CredAcct1= string.Empty;
          this.DebAmnt1= string.Empty;
          this.credAmnt1= string.Empty;
          this.FDebAmnt1= string.Empty;
          this.FCredAmnt1= string.Empty;
          this.Filler= string.Empty;
          this.EndField= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CurrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Memo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DebAcct1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CredAcct1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DebAmnt1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string credAmnt1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FDebAmnt1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FCredAmnt1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Filler { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EndField { get; set; }
    }
}