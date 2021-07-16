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
    public partial class CSN1 
    {
        public CSN1()
        {
          this.BeginStr= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BeginStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InitialNum { get; set; }
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