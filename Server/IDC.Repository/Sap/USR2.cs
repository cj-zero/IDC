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
    public partial class USR2 
    {
        public USR2()
        {
          this.PATH1= string.Empty;
          this.PATH2= string.Empty;
          this.PATH3= string.Empty;
          this.PATH4= string.Empty;
          this.PATH5= string.Empty;
          this.PATH6= string.Empty;
          this.PATH7= string.Empty;
          this.PATH8= string.Empty;
          this.PATH9= string.Empty;
          this.PATH10= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PATH1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PATH2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PATH3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PATH4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PATH5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PATH6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PATH7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PATH8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PATH9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PATH10 { get; set; }
    }
}