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
    public partial class GPA1 
    {
        public GPA1()
        {
          this.ItemCode= string.Empty;
          this.ItemName= string.Empty;
          this.DocType= string.Empty;
          this.Selected= string.Empty;
          this.DistNumber= string.Empty;
          this.PostDate= DateTime.Now;
          this.WhsCode= string.Empty;
          this.CogsAcct= string.Empty;
          this.BaseType= string.Empty;
          this.Execute= string.Empty;
          this.IsMixed= string.Empty;
          this.LineType= string.Empty;
          this.ChDocType= string.Empty;
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
        public string DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ManagedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Selected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DistNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CogsAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CogsAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SalesAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrssProfit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? COGSByCC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GPByCC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DeltaGP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SalesPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BatchQt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SnBAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AccQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SBAccTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SBAccQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Execute { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SBCogsAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SBSaleAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SBGrssProf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SBGrPrPerc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrPrPerc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GPPercByCC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DeltaGPLn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Applied { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SBAccTtAdj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsMixed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CogsAmByCC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrssPrByCC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChDocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ChDocAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WasQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WasCogs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WasSales { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WasPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WasGrProf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WasNewCogs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ChDocLine { get; set; }
    }
}