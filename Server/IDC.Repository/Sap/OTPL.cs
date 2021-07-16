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
    public partial class OTPL 
    {
        public OTPL()
        {
          this.TplName= string.Empty;
          this.TplType= string.Empty;
          this.TplCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TplName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TplType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TplCode { get; set; }
    }
}