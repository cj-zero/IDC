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
    public partial class ORSG 
    {
        public ORSG()
        {
          this.ResGrpNam= string.Empty;
          this.UserSign= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResGrpNam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserSign { get; set; }
    }
}