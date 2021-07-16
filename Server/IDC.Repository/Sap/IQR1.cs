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
    public partial class IQR1 
    {
        public IQR1()
        {
          this.ItemCode= string.Empty;
          this.ItemName= string.Empty;
          this.InvntryUom= string.Empty;
          this.Currency= string.Empty;
          this.IOffIncAcc= string.Empty;
          this.DOffDecAcc= string.Empty;
          this.OcrCode= string.Empty;
          this.WhsCode= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.ObjType= string.Empty;
          this.Project= string.Empty;
          this.BarCode= string.Empty;
          this.InvUoM= string.Empty;
          this.SuppCatNum= string.Empty;
          this.CardCode= string.Empty;
          this.CountDate= DateTime.Now;
          this.BaseRef= string.Empty;
          this.Remark= string.Empty;
          this.BinNegQty= string.Empty;
          this.IUomEntry= string.Empty;
          this.UomCode= string.Empty;
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
        public string ItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvntryUom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OnHandBef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IOffIncAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DOffDecAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotalSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BarCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvUoM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BinEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FirmCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SuppCatNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CountDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CountTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DiffPercnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseType { get; set; }
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
        public decimal? CountQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CpyCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinNegQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VisOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UgpEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IUomEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UomCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ItmsPerUnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UomQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ActPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PostValueL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PostValueS { get; set; }
    }
}