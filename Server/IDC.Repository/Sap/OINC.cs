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
    public partial class OINC 
    {
        public OINC()
        {
          this.DocNum= 0;
          this.Series= 0;
          this.CountDate= DateTime.Now;
          this.CountType= string.Empty;
          this.Status= string.Empty;
          this.Ref2= string.Empty;
          this.Remarks= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.ObjType= string.Empty;
          this.WddStatus= string.Empty;
          this.Printed= string.Empty;
          this.BPLName= string.Empty;
          this.PIndicator= string.Empty;
          this.PostDate= DateTime.Now;
          this.VersionNum= string.Empty;
          this.DataSource= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CountDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CountType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Taker1Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? Taker1Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Taker2Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? Taker2Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogIns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WddStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DraftKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Printed { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TeamCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IndvCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DiffQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DiffPercen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UpdateTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PIndicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FinncPriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VersionNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
    }
}