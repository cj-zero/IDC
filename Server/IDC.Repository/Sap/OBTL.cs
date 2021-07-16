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
    public partial class OBTL 
    {
        public OBTL()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MessageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BinAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SnBMDAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ITLEntry { get; set; }
    }
}