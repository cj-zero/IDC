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
    public partial class USR1 
    {
        public USR1()
        {
          this.STATUS= string.Empty;
          this.MODIF01= string.Empty;
          this.MODIF02= string.Empty;
          this.MODIF03= string.Empty;
          this.MODIF04= string.Empty;
          this.MODIF05= string.Empty;
          this.MODIF06= string.Empty;
          this.MODIF07= string.Empty;
          this.MODIF08= string.Empty;
          this.MODIF09= string.Empty;
          this.MODIF10= string.Empty;
          this.MODIF11= string.Empty;
          this.MODIF12= string.Empty;
          this.MODIF13= string.Empty;
          this.RESERVED= string.Empty;
          this.FILLER= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string STATUS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MODIF01 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MODIF02 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MODIF03 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MODIF04 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MODIF05 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MODIF06 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MODIF07 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MODIF08 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MODIF09 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MODIF10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MODIF11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MODIF12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MODIF13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ATOMID01 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ATOMID02 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ATOMID03 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ATOMID04 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ATOMID05 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ATOMID06 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ATOMID07 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ATOMID08 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ATOMID09 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ATOMID10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ATOMID11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ATOMID12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ATOMID13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STRID01 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STRID02 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STRID03 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STRID04 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STRID05 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STRID06 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STRID07 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STRID08 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STRID09 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STRID10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STRID11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STRID12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STRID13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RESERVED { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FILLER { get; set; }
    }
}