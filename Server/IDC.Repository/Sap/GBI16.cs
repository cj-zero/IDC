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
    public partial class GBI16 
    {
        public GBI16()
        {
          this.EmpNo= string.Empty;
          this.EmpName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmpNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmpName { get; set; }
    }
}