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
    public partial class AIT13 
    {
        public AIT13()
        {
          this.AttriTxt1= string.Empty;
          this.AttriTxt2= string.Empty;
          this.AttriTxt3= string.Empty;
          this.AttriTxt4= string.Empty;
          this.AttriTxt5= string.Empty;
          this.AttriTxt6= string.Empty;
          this.AttriTxt7= string.Empty;
          this.AttriTxt8= string.Empty;
          this.AttriTxt9= string.Empty;
          this.AttriTxt10= string.Empty;
          this.AttriTxt11= string.Empty;
          this.AttriTxt12= string.Empty;
          this.AttriTxt13= string.Empty;
          this.AttriTxt14= string.Empty;
          this.AttriTxt15= string.Empty;
          this.AttriTxt16= string.Empty;
          this.AttriTxt17= string.Empty;
          this.AttriTxt18= string.Empty;
          this.AttriTxt19= string.Empty;
          this.AttriTxt20= string.Empty;
          this.AttriTxt21= string.Empty;
          this.AttriTxt22= string.Empty;
          this.AttriTxt23= string.Empty;
          this.AttriTxt24= string.Empty;
          this.AttriTxt25= string.Empty;
          this.AttriTxt26= string.Empty;
          this.AttriTxt27= string.Empty;
          this.AttriTxt28= string.Empty;
          this.AttriTxt29= string.Empty;
          this.AttriTxt30= string.Empty;
          this.AttriTxt31= string.Empty;
          this.AttriTxt32= string.Empty;
          this.AttriDt43= DateTime.Now;
          this.AttriDt44= DateTime.Now;
          this.AttriDt45= DateTime.Now;
          this.AttriDt46= DateTime.Now;
          this.AttriDt47= DateTime.Now;
          this.ObjType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttriTxt32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AttriInt33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AttriInt34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AttriInt35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AttriInt36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AttriInt37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AttriInt38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AttriInt39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AttriInt40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AttriInt41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AttriInt42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? AttriDt43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? AttriDt44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? AttriDt45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? AttriDt46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? AttriDt47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriAm48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriAm49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriAm50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriAm51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriAm52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriAm53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriAm54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriPr55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriPr56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriPr57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriPr58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriPr59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriQTY60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriQTY61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriQTY62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriQTY63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AttriQTY64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
    }
}