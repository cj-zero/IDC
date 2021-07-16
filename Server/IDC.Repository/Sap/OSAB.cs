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
    public partial class OSAB 
    {
        public OSAB()
        {
          this.SocialName= string.Empty;
          this.SocialUrl= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SocialName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SocialUrl { get; set; }
    }
}