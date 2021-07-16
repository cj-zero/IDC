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
    public partial class AIT11 
    {
        public AIT11()
        {
          this.DprSt= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DprSt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? factor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActualUnit { get; set; }
    }
}