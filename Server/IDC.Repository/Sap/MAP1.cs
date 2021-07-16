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
    public partial class MAP1 
    {
        public MAP1()
        {
          this.Type= string.Empty;
          this.RuleType= string.Empty;
          this.RuleRef= string.Empty;
          this.RefID= string.Empty;
          this.RuleVer= string.Empty;
          this.IsFinal= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RuleType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RuleRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RuleVer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsFinal { get; set; }
    }
}