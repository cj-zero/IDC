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
    public partial class ACPA1 
    {
        public ACPA1()
        {
          this.AcctFrom= string.Empty;
          this.AcctTo= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctTo { get; set; }
    }
}