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
    public partial class FNS1 
    {
        public FNS1()
        {
          this.FolNumTo= 0;
          this.Reason= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int FolNumTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Reason { get; set; }
    }
}