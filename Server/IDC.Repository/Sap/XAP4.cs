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
    public partial class XAP4 
    {
        public XAP4()
        {
          this.TarType= string.Empty;
          this.TarField= string.Empty;
          this.IsBase= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FilEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TarEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TarType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TarField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsBase { get; set; }
    }
}