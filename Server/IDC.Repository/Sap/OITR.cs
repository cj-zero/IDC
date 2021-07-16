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
    public partial class OITR 
    {
        public OITR()
        {
          this.IsCard= string.Empty;
          this.ReconType= string.Empty;
          this.ReconDate= DateTime.Now;
          this.ReconCurr= string.Empty;
          this.Canceled= string.Empty;
          this.IsSystem= string.Empty;
          this.InitObjTyp= string.Empty;
          this.CreateDate= DateTime.Now;
          this.DataSource= string.Empty;
          this.ReconRule1= string.Empty;
          this.ReconRule2= string.Empty;
          this.ReconRule3= string.Empty;
          this.IsMultiBP= string.Empty;
          this.VersionNum= string.Empty;
          this.BuildDesc= string.Empty;
          this.BPLName= string.Empty;
          this.VATRegNum= string.Empty;
          this.IsElectr= string.Empty;
          this.ObjType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReconType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ReconDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Total { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReconCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Canceled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CancelAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsSystem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InitObjTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InitObjAbs { get; set; }
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
        public string ReconRule1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReconRule2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReconRule3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsMultiBP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VersionNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OldMatNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? ReconJEId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BuildDesc { get; set; }
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
        public string BPLName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VATRegNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsElectr { get; set; }
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
        public string ObjType { get; set; }
    }
}