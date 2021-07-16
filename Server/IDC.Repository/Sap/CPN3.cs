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
    public partial class CPN3 
    {
        public CPN3()
        {
          this.RelatCard= string.Empty;
          this.Memo= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? ParterId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OrlCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RelatCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Memo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogIns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VisOrder { get; set; }
    }
}