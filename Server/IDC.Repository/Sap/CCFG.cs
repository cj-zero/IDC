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
    public partial class CCFG 
    {
        public CCFG()
        {
          this.ConfigName= string.Empty;
          this.ConfigDate= DateTime.Now;
          this.ServerName= string.Empty;
          this.CompanyDB= string.Empty;
          this.Internal= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ConfigName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ConfigDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ConfigTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UserCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CreateBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ServerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompanyDB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Internal { get; set; }
    }
}