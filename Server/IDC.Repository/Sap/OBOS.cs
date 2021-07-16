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
    public partial class OBOS 
    {
        public OBOS()
        {
          this.IsUsed= string.Empty;
          this.EffecDate= DateTime.Now;
          this.IsDeleted= string.Empty;
          this.ReportType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsUsed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime EffecDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FileFmtCo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsDeleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReportType { get; set; }
    }
}