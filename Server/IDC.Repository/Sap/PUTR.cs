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
    public partial class PUTR 
    {
        public PUTR()
        {
          this.CompanyVer= string.Empty;
          this.TargetVer= string.Empty;
          this.BeginTime= string.Empty;
          this.EndTime= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompanyVer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TargetVer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BeginTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EndTime { get; set; }
    }
}