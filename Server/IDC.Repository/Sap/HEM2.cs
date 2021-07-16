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
    public partial class HEM2 
    {
        public HEM2()
        {
          this.fromDate= DateTime.Now;
          this.toDate= DateTime.Now;
          this.institute= string.Empty;
          this.major= string.Empty;
          this.diploma= string.Empty;
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
        public int? type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string institute { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string major { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string diploma { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}