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
    public partial class HMM2 
    {
        public HMM2()
        {
          this.VerType= string.Empty;
          this.Ver= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VerType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ver { get; set; }
    }
}