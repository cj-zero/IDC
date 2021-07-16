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
    public partial class NCP1 
    {
        public NCP1()
        {
          this.Type= string.Empty;
          this.Size= string.Empty;
          this.Settings= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PageEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? WidgetId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Index { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Settings { get; set; }
    }
}