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
    public partial class HEM5 
    {
        public HEM5()
        {
          this.Peer= string.Empty;
          this.Manager= string.Empty;
          this.Subord= string.Empty;
          this.Dept= string.Empty;
          this.Branch= string.Empty;
          this.Team= string.Empty;
          this.Cmpny= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Peer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Manager { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Subord { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dept { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Branch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Team { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Cmpny { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}