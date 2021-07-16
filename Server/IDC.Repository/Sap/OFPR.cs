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
    public partial class OFPR 
    {
        public OFPR()
        {
          this.Code= string.Empty;
          this.Name= string.Empty;
          this.F_RefDate= DateTime.Now;
          this.T_RefDate= DateTime.Now;
          this.F_DueDate= DateTime.Now;
          this.T_DueDate= DateTime.Now;
          this.F_TaxDate= DateTime.Now;
          this.T_TaxDate= DateTime.Now;
          this.Free2= string.Empty;
          this.Free3= string.Empty;
          this.DataSource= string.Empty;
          this.Free= string.Empty;
          this.Free1= string.Empty;
          this.Addition= string.Empty;
          this.Category= string.Empty;
          this.Indicator= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.WasStatChd= string.Empty;
          this.PeriodStat= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? F_RefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? T_RefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? F_DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? T_DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? F_TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? T_TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Free2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Free3 { get; set; }
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
        public int? SubNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Free { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Free1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Addition { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AddNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Indicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WasStatChd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PeriodStat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
    }
}