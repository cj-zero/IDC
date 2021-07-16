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
    public partial class AEC6 
    {
        public AEC6()
        {
          this.GenType= string.Empty;
          this.TestMode= string.Empty;
          this.ParamLogic= string.Empty;
          this.ParamStr= string.Empty;
          this.ParamLText= string.Empty;
          this.ActStatus= string.Empty;
          this.ParamPAC= string.Empty;
          this.ParamTgl= string.Empty;
          this.ParamMon= string.Empty;
          this.ParamLink= string.Empty;
          this.Source= string.Empty;
          this.ReportID= string.Empty;
          this.AssignedID= string.Empty;
          this.Confirm= string.Empty;
          this.PayMethod= string.Empty;
          this.CancStatus= string.Empty;
          this.CancRecons= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GenType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MapID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MapID_WS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TestMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamLogic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamLText { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ParamUqc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ParamInt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamPAC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamTgl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamMon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Frequency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Source { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AssignedID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Confirm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CancStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CancRecons { get; set; }
    }
}