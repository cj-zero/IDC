using System;
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
    public partial class ORCN 
    {
        public ORCN()
        {
          this.ChainName= string.Empty;
          this.SuppNum= string.Empty;
          this.SuppName= string.Empty;
          this.Locked= string.Empty;
          this.SavePath= string.Empty;
          this.UsePartSup= string.Empty;
          this.DataSource= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChainName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SuppNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SuppName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SavePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UsePartSup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExportNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
    }
}