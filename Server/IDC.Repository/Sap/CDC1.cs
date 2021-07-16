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
    public partial class CDC1 
    {
        public CDC1()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? NumOfDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Discount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Day { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Month { get; set; }
    }
}