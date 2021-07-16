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
    public partial class IWB1 
    {
        public IWB1()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BtqAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MdAbsEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CountedQty { get; set; }
    }
}