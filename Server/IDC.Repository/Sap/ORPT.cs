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
    public partial class ORPT 
    {
        public ORPT()
        {
          this.Dscrptn= string.Empty;
          this.IsActived= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dscrptn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsActived { get; set; }
    }
}