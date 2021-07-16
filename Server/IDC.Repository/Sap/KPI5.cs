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
    public partial class KPI5 
    {
        public KPI5()
        {
          this.VarName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? KPIEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CalcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VarName { get; set; }
    }
}