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
    public partial class ODAR 
    {
        public ODAR()
        {
          this.PeriodDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.JEPerLen= string.Empty;
          this.JERef1= string.Empty;
          this.JERef2= string.Empty;
          this.JEMemo= string.Empty;
          this.JEByProj= string.Empty;
          this.JEByProf= string.Empty;
          this.INPerLen= string.Empty;
          this.INRef1= string.Empty;
          this.INRef2= string.Empty;
          this.INMemo= string.Empty;
          this.JEByCurr= string.Empty;
          this.JEByDIM2= string.Empty;
          this.JEByDIM3= string.Empty;
          this.JEByDIM4= string.Empty;
          this.JEByDIM5= string.Empty;
          this.INZeroPrc= string.Empty;
          this.DelNonReco= string.Empty;
          this.RunName= string.Empty;
          this.RODBGUID= string.Empty;
          this.ArchMethod= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PeriodDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VersionNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JEPerLen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JERef1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JERef2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JEMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JEByProj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JEByProf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string INPerLen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? INPriceSrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string INRef1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string INRef2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string INMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JEByCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JEByDIM2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JEByDIM3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JEByDIM4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JEByDIM5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DBReduc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DBReducPer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TrandReduc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TranReducP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string INZeroPrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TranRedArP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DelNonReco { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RunName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RODBGUID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArchMethod { get; set; }
    }
}