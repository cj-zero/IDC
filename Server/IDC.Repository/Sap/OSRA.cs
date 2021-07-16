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
    public partial class OSRA 
    {
        public OSRA()
        {
          this.Title= string.Empty;
          this.Notes= string.Empty;
          this.Password= string.Empty;
          this.RunDate= DateTime.Now;
          this.Active= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndType= string.Empty;
          this.EndDate= DateTime.Now;
          this.MissBehav= string.Empty;
          this.RcrType= string.Empty;
          this.ErrAct= string.Empty;
          this.TransfXslt= string.Empty;
          this.MsgTitle= string.Empty;
          this.MsgBody= string.Empty;
          this.LicSrvr= string.Empty;
          this.LstRunStat= string.Empty;
          this.PrntLayout= string.Empty;
          this.Finished= string.Empty;
          this.SLDAddr= string.Empty;
          this.ObjType= string.Empty;
          this.DFType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Notes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UserKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RunDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RunTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RunCounter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ReportType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EndType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EndCounter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MissBehav { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RcrType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RcrIntervl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RcrSubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RcrData2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RcrData1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ErrAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransfXslt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TimeOut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MsgTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MsgBody { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LicSrvr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Language { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LstRunStat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ErrorCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrntLayout { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DistLstCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Finished { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SLDAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ObjAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OnceAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Every { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StartAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EndAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DFType { get; set; }
    }
}