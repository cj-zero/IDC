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
    public partial class CDPM 
    {
        public CDPM()
        {
          this.Name= string.Empty;
          this.ObjectKey= string.Empty;
          this.System= string.Empty;
          this.Hidden= string.Empty;
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
        public int? Father { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PermOption { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string System { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Hidden { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SortOrder { get; set; }
    }
}