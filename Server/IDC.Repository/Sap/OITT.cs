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
    public partial class OITT 
    {
        public OITT()
        {
          this.TreeType= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.Transfered= string.Empty;
          this.DataSource= string.Empty;
          this.DispCurr= string.Empty;
          this.ToWH= string.Empty;
          this.Object= string.Empty;
          this.OcrCode= string.Empty;
          this.HideComp= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.Project= string.Empty;
          this.Name= string.Empty;
          this.U_ZS= string.Empty;
          this.U_BBH= string.Empty;
          this.U_XH= string.Empty;
          this.U_BOM_CZ= string.Empty;
          this.U_job_id= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TreeType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PriceList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Qauntity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
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
        public short? SCNCounter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DispCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToWH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Object { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstac { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HideComp { get; set; }
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
        public int? UpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PlAvgSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CreateTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UpdateTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_BBH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_XH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_BOM_CZ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_job_id { get; set; }
    }
}