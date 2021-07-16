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
    public partial class XAP2 
    {
        public XAP2()
        {
          this.Type= string.Empty;
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
        public int? ObjEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Index { get; set; }
    }
}