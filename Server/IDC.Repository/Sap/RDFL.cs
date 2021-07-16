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
    public partial class RDFL 
    {
        public RDFL()
        {
          this.DfltReport= string.Empty;
          this.TYPE= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltReport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DfltSeq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TYPE { get; set; }
    }
}