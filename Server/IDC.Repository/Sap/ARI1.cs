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
    public partial class ARI1 
    {
        public ARI1()
        {
          this.AddOnType= string.Empty;
          this.EnableFlag= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddOnType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnableFlag { get; set; }
    }
}