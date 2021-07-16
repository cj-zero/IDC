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
    public partial class OBST 
    {
        public OBST()
        {
          this.Amount= 0;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StampTax { get; set; }
    }
}