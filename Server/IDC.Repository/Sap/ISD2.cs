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
    public partial class ISD2 
    {
        public ISD2()
        {
          this.TarLocName= string.Empty;
          this.ITCType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TarLocName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AllocAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ITCType { get; set; }
    }
}