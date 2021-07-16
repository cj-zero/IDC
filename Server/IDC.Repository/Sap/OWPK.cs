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
    public partial class OWPK 
    {
        public OWPK()
        {
          this.PackagCode= string.Empty;
          this.PackagName= string.Empty;
          this.Note= string.Empty;
          this.Author= string.Empty;
          this.Version= string.Empty;
          this.CreateDate= DateTime.Now;
          this.IsSystem= string.Empty;
          this.PackagType= string.Empty;
          this.ISIMDB= string.Empty;
          this.StraType= string.Empty;
          this.StraPara= string.Empty;
          this.SourceType= string.Empty;
          this.ViewName= string.Empty;
          this.ViewCtg= string.Empty;
          this.ViewSyn= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PackagCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PackagName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Note { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Author { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Version { get; set; }
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
        public string IsSystem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PackagType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISIMDB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StraType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StraPara { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ViewName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ViewCtg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ViewSyn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Viewid { get; set; }
    }
}