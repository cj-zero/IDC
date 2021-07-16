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
    public partial class OBTA 
    {
        public OBTA()
        {
          this.Status= string.Empty;
          this.Canceled= string.Empty;
          this.DocNum= 0;
          this.StateUf= string.Empty;
          this.PostDate= DateTime.Now;
          this.CodDa= string.Empty;
          this.NumDa= string.Empty;
          this.CodAut= string.Empty;
          this.DtVcto= DateTime.Now;
          this.DtPgto= DateTime.Now;
          this.CodAj= string.Empty;
          this.DescCompAj= string.Empty;
          this.CodAjApur= string.Empty;
          this.NumProc= string.Empty;
          this.IndProc= string.Empty;
          this.Ser= string.Empty;
          this.Sub= string.Empty;
          this.DtDoc= DateTime.Now;
          this.CodMod= string.Empty;
          this.CodPart= string.Empty;
          this.CodRec= string.Empty;
          this.GLAcct= string.Empty;
          this.ItemCode= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Canceled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TaxCat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Oper { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RefVisType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RefObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RefDocEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RefDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StateUf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CodDa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NumDa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CodAut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VlDa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VlDaSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DtVcto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DtPgto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CodAj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DescCompAj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcIcms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcIcmsSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AliqIcms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VlIcms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VlIcmsSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VlOutros { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CodAjApur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NumProc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IndProc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Sub { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DtDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CodMod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CodPart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CodRec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GLAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
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
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TransId { get; set; }
    }
}