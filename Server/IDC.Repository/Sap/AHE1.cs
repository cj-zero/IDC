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
    public partial class AHE1 
    {
        public AHE1()
        {
          this.fromDate= DateTime.Now;
          this.toDate= DateTime.Now;
          this.reason= string.Empty;
          this.approvedBy= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? fromDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? toDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string reason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string approvedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? cnfrmrNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}