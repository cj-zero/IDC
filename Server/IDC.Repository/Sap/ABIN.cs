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
    public partial class ABIN 
    {
        public ABIN()
        {
          this.BinCode= string.Empty;
          this.WhsCode= string.Empty;
          this.SysBin= string.Empty;
          this.SL1Code= string.Empty;
          this.SL2Code= string.Empty;
          this.SL3Code= string.Empty;
          this.SL4Code= string.Empty;
          this.Attr1Val= string.Empty;
          this.Attr2Val= string.Empty;
          this.Attr3Val= string.Empty;
          this.Attr4Val= string.Empty;
          this.Attr5Val= string.Empty;
          this.Attr6Val= string.Empty;
          this.Attr7Val= string.Empty;
          this.Attr8Val= string.Empty;
          this.Attr9Val= string.Empty;
          this.Attr10Val= string.Empty;
          this.Disabled= string.Empty;
          this.Descr= string.Empty;
          this.BarCode= string.Empty;
          this.AltSortCod= string.Empty;
          this.SpcItmCode= string.Empty;
          this.SngBatch= string.Empty;
          this.RtrictResn= string.Empty;
          this.RtrictDate= DateTime.Now;
          this.DataSource= string.Empty;
          this.Transfered= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.Deleted= string.Empty;
          this.ReceiveBin= string.Empty;
          this.NoAutoAllc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SysBin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SL1Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SL1Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SL2Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SL2Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SL3Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SL3Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SL4Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SL4Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Attr1Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attr1Val { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Attr2Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attr2Val { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Attr3Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attr3Val { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Attr4Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attr4Val { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Attr5Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attr5Val { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Attr6Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attr6Val { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Attr7Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attr7Val { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Attr8Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attr8Val { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Attr9Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attr9Val { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Attr10Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attr10Val { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Disabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BarCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AltSortCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItmRtrictT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpcItmCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SpcItmGrpC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SngBatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RtrictType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RtrictResn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RtrictDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
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
        public System.DateTime? CreateDate { get; set; }
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
        public string Deleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReceiveBin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NoAutoAllc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxWeight1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Wght1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxWeight2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Wght2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UoMRtrict { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SpcUoMCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SpcUGPCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SngUoMCode { get; set; }
    }
}