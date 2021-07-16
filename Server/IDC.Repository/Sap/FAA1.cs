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
    public partial class FAA1 
    {
        public FAA1()
        {
          this.AttrID= 0;
          this.AttrName= string.Empty;
          this.FieldType= string.Empty;
          this.DefaultVal= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int AttrID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttrName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FieldType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DefaultVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? SnapshotId { get; set; }
    }
}