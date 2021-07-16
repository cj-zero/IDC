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
    public partial class ARC8 
    {
        public ARC8()
        {
          this.InvType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PaidEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PaidLine { get; set; }
    }
}