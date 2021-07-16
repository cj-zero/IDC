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
    public partial class OFNS 
    {
        public OFNS()
        {
          this.Name= string.Empty;
          this.PTICode= string.Empty;
          this.Letter= string.Empty;
          this.CAI= string.Empty;
          this.CAIDueDate= DateTime.Now;
          this.Remarks= string.Empty;
          this.Locked= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PTICode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FirstNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NextNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LastNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Letter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CAI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CAIDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
    }
}