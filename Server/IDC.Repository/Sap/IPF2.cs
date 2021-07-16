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
    public partial class IPF2 
    {
        public IPF2()
        {
          this.OhType= string.Empty;
          this.Locked= string.Empty;
          this.LaCAllcAcc= string.Empty;
          this.InCustCalc= string.Empty;
          this.AgentCode= string.Empty;
          this.AgentName= string.Empty;
          this.CostCateg= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OhType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Factor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LaCAllcAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InCustCalc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenCostFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenCostSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AgentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AgentName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostCateg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}