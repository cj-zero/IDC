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
    public partial class IMQSG 
    {
        public IMQSG()
        {
          this.Content= string.Empty;
          this.Time= DateTime.Now;
          this.Owner= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Weight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Language { get; set; }
    }
}