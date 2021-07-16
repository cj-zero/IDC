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
    public partial class TRN2 
    {
        public TRN2()
        {
          this.LangCode= 0;
          this.Text= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int LangCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Text { get; set; }
    }
}