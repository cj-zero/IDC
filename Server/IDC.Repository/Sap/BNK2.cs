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
    public partial class BNK2 
    {
        public BNK2()
        {
          this.DocID= string.Empty;
          this.IsDebit= string.Empty;
          this.GLAct= string.Empty;
          this.PrftCenter= string.Empty;
          this.Project= string.Empty;
          this.VatCode= string.Empty;
          this.Selected= string.Empty;
          this.InterimAct= string.Empty;
          this.PrftCent2= string.Empty;
          this.PrftCent3= string.Empty;
          this.PrftCent4= string.Empty;
          this.PrftCent5= string.Empty;
          this.MatchLog= string.Empty;
          this.BPLName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmntLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsDebit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GLAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCenter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Selected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Installmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InterimAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? JdtLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCent2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCent3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCent4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrftCent5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MatchLog { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DueBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DueBalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmntSC { get; set; }
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
        public string BPLName { get; set; }
    }
}