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
    public partial class MABV 
    {
        public MABV()
        {
          this.pkgName= string.Empty;
          this.fileName= string.Empty;
          this.imprtDate= DateTime.Now;
          this.pkgPath= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string pkgName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string fileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? imprtDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string pkgPath { get; set; }
    }
}