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
    public partial class OERT 
    {
        public OERT()
        {
          this.NumTypeNam= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NumTypeNam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FirstNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NextNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LastNum { get; set; }
    }
}