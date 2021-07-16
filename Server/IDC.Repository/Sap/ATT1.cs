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
    public partial class ATT1 
    {
        public ATT1()
        {
          this.VisOrder= 0;
          this.Code= string.Empty;
          this.Warehouse= string.Empty;
          this.Currency= string.Empty;
          this.OrigCurr= string.Empty;
          this.IssueMthd= string.Empty;
          this.Uom= string.Empty;
          this.Comment= string.Empty;
          this.Object= string.Empty;
          this.OcrCode= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.PrncpInput= string.Empty;
          this.Project= string.Empty;
          this.WipActCode= string.Empty;
          this.LineText= string.Empty;
          this.U_Desc= string.Empty;
          this.U_DUnit= string.Empty;
          this.U_PCB= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int VisOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
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
        public short? PriceList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrigPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrigCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IssueMthd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Uom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Object { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
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
        public string PrncpInput { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WipActCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AddQuantit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineText { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? StageId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_Desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_DUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PCB { get; set; }
    }
}