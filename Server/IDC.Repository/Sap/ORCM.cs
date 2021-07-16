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
    public partial class ORCM 
    {
        public ORCM()
        {
          this.ItemCode= string.Empty;
          this.DueDate= DateTime.Now;
          this.OrderType= string.Empty;
          this.UOM= string.Empty;
          this.CardCode= string.Empty;
          this.Warehouse= string.Empty;
          this.Currency= string.Empty;
          this.Origin= string.Empty;
          this.Status= string.Empty;
          this.DocDate= DateTime.Now;
          this.ReleasDate= DateTime.Now;
          this.FromWhse= string.Empty;
          this.FstReqDate= DateTime.Now;
          this.UseDiscnt= string.Empty;
          this.PriceMode= string.Empty;
          this.RouDatCalc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ObjAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrderType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UOM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Warehouse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Origin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DocTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BPLid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PriceBefDi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DiscPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ReleasDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PriceAftV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromWhse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FstReqDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UomEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NumPerMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AgrNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AgrLnNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseDiscnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriceMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RouDatCalc { get; set; }
    }
}