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
    public partial class XRUDF 
    {
        public XRUDF()
        {
          this.ColumnId= string.Empty;
          this.Module= string.Empty;
          this.Descriptio= string.Empty;
          this.MetaName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string ColumnId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Module { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AttributeT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descriptio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MetaName { get; set; }
    }
}