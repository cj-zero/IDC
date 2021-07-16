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
    public partial class INC5 
    {
        public INC5()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogIns { get; set; }
    }
}