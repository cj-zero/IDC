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
    public partial class OPR1 
    {
        public OPR1()
        {
          this.OpenDate= DateTime.Now;
          this.CloseDate= DateTime.Now;
          this.Memo= string.Empty;
          this.ObjType= string.Empty;
          this.Status= string.Empty;
          this.Linked= string.Empty;
          this.ChnCrdCode= string.Empty;
          this.ChnCrdName= string.Empty;
          this.DocChkbox= string.Empty;
          this.EncryptIV= string.Empty;
          this.U_PRX_SID= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SlpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CntctCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? OpenDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CloseDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? Step_Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ClosePrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxSumLoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxSumSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Memo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? DocId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Linked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtSumLoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtSumSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChnCrdCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChnCrdName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ChnCrdCon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocChkbox { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_SID { get; set; }
    }
}