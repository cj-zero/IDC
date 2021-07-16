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
    public partial class ORCR 
    {
        public ORCR()
        {
          this.RcurDesc= string.Empty;
          this.Frequency= string.Empty;
          this.LastPosted= DateTime.Now;
          this.NextDeu= DateTime.Now;
          this.VolCurr= string.Empty;
          this.Ref1= string.Empty;
          this.Ref2= string.Empty;
          this.TransCode= string.Empty;
          this.Memo= string.Empty;
          this.LimitRtrns= string.Empty;
          this.LimitDate= DateTime.Now;
          this.DataSource= string.Empty;
          this.StampTax= string.Empty;
          this.AutoVat= string.Empty;
          this.ManageWTax= string.Empty;
          this.Ref3= string.Empty;
          this.DeferedTax= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RcurDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Frequency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Remind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LastPosted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? NextDeu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? EntryCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Volume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VolCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FinancVol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Memo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LimitRtrns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Returns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LimitDate { get; set; }
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
        public string StampTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManageWTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeferedTax { get; set; }
    }
}