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
    public partial class ORSB 
    {
        public ORSB()
        {
          this.ResGrpNam= string.Empty;
          this.Locked= string.Empty;
          this.DataSource= string.Empty;
          this.Object= string.Empty;
          this.createDate= DateTime.Now;
          this.updateDate= DateTime.Now;
          this.ResType= string.Empty;
          this.CostName1= string.Empty;
          this.CostName2= string.Empty;
          this.CostName3= string.Empty;
          this.CostName4= string.Empty;
          this.CostName5= string.Empty;
          this.CostName6= string.Empty;
          this.CostName7= string.Empty;
          this.CostName8= string.Empty;
          this.CostName9= string.Empty;
          this.CostName10= string.Empty;
          this.ResUoM= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResGrpNam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
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
        public string Object { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? logInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? createDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? userSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? updateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostName1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostVal1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostName2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostVal2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostName3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostVal3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostName4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostVal4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostName5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostVal5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostName6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostVal6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostName7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostVal7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostName8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostVal8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostName9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostVal9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostName10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostVal10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResUoM { get; set; }
    }
}