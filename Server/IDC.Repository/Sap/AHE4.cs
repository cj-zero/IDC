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
    public partial class AHE4 
    {
        public AHE4()
        {
          this.fromDate= DateTime.Now;
          this.toDate= DateTime.Now;
          this.employer= string.Empty;
          this.position= string.Empty;
          this.remarks= string.Empty;
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
        public string employer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}