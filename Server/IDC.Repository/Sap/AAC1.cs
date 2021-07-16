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
    public partial class AAC1 
    {
        public AAC1()
        {
          this.DprAreaID= string.Empty;
          this.Active= string.Empty;
          this.AcctDtn= string.Empty;
          this.DprTypID= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DprAreaID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctDtn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DprTypID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UseLife { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? SnapshotId { get; set; }
    }
}