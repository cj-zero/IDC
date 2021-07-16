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
    public partial class OAIB 
    {
        public OAIB()
        {
          this.Opened= string.Empty;
          this.RecDate= DateTime.Now;
          this.WasRead= string.Empty;
          this.Deleted= string.Empty;
          this.Failed= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Opened { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RecDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RecTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WasRead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Deleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Failed { get; set; }
    }
}