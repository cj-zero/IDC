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
    public partial class WPK2 
    {
        public WPK2()
        {
          this.Value= string.Empty;
          this.Desc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FltEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Desc { get; set; }
    }
}