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
    public partial class ADP2 
    {
        public ADP2()
        {
          this.EmailSbj= string.Empty;
          this.EmailBody= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmailSbj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmailBody { get; set; }
    }
}