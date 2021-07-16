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
    public partial class OBGD 
    {
        public OBGD()
        {
          this.BgdName= string.Empty;
          this.DataSource= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BgdName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BgdTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Month1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Month2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Month3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Month4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Month5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Month6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Month7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Month8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Month9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Month10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Month11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Month12 { get; set; }
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
    }
}