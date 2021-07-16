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
    public partial class OIVQ 
    {
        public OIVQ()
        {
          this.LocCode= string.Empty;
          this.TransSeq= 0;
          this.LayerID= 0;
          this.ItemCode= string.Empty;
          this.RemMethod= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TreeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ParentID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LocCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int TransSeq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int LayerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StockActio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RemMethod { get; set; }
    }
}