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
    public partial class APRC 
    {
        public APRC()
        {
          this.PrcName= string.Empty;
          this.GrpCode= string.Empty;
          this.Locked= string.Empty;
          this.DataSource= string.Empty;
          this.CCTypeCode= string.Empty;
          this.ValidFrom= DateTime.Now;
          this.ValidTo= DateTime.Now;
          this.Active= string.Empty;
          this.UpdateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrcName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GrpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Balance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
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
        public short? DimCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CCTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValidFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValidTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CCOwner { get; set; }
    }
}