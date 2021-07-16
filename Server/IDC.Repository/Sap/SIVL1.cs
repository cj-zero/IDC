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
    public partial class SIVL1 
    {
        public SIVL1()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CalcPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Balance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TransValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LayerInQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LayerOutQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RevalTotal { get; set; }
    }
}