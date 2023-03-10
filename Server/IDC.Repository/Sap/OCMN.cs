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
    public partial class OCMN 
    {
        public OCMN()
        {
          this.Name= string.Empty;
          this.Father= string.Empty;
          this.Type= string.Empty;
          this.SubMenu= string.Empty;
          this.MenuUID= string.Empty;
          this.ObjectKey= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Father { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubMenu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MenuUID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PermFolder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SortOrder { get; set; }
    }
}