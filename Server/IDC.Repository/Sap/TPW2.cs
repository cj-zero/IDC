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
    public partial class TPW2 
    {
        public TPW2()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TaxCategry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TaxType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PyblAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PyblAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PyblAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PLAAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PLAAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PLAAmntSC { get; set; }
    }
}