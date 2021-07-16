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
    public partial class GBI11 
    {
        public GBI11()
        {
          this.ItemName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BOPBalance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CurDebit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CurCredit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EOPBalance { get; set; }
    }
}