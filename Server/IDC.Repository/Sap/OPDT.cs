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
    public partial class OPDT 
    {
        public OPDT()
        {
          this.TextCode= string.Empty;
          this.Text= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TextCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Text { get; set; }
    }
}