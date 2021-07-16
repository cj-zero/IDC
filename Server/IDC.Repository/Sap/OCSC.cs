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
    public partial class OCSC 
    {
        public OCSC()
        {
          this.Name= string.Empty;
          this.User= string.Empty;
          this.Password= string.Empty;
          this.URL= string.Empty;
          this.IsDefault= string.Empty;
          this.Port= string.Empty;
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
        public string User { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string URL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsDefault { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Port { get; set; }
    }
}