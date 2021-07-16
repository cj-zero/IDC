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
    public partial class ADT1 
    {
        public ADT1()
        {
          this.Base= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Base { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Years { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Percentage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? SnapshotId { get; set; }
    }
}