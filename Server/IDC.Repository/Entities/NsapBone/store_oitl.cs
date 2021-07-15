﻿using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDC.Repository.Entities.NsapBone
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("NsapBoneDbContext","NsapBoneReadDbContext")]
    public partial class store_oitl 
    {
        public store_oitl()
        {
          this.ItemCode= string.Empty;
          this.ItemName= string.Empty;
          this.DocDate= DateTime.Now;
          this.CardCode= string.Empty;
          this.CardName= string.Empty;
          this.CreateDate= DateTime.Now;
          this.LocCode= string.Empty;
          this.VersionNum= string.Empty;
          this.Transfered= string.Empty;
        }


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? sbo_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ManagedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ApplyEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ApplyLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ApplyType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StockQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DefinedQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StockEff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LocCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AppDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VersionNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Instance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SubLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BSubLineNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AppSubLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActBaseTp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActBaseEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActBaseLn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActBasSubL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AllocateTp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AllocatEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AllocateLn { get; set; }
    }
}