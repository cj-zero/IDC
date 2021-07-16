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
    public partial class OTCD 
    {
        public OTCD()
        {
          this.TcdType= string.Empty;
          this.DftArCode= string.Empty;
          this.DftApCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TcdType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DftArCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DftApCode { get; set; }
    }
}