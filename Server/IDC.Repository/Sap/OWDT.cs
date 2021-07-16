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
    public partial class OWDT 
    {
        public OWDT()
        {
          this.Name= string.Empty;
          this.UserSign= string.Empty;
          this.Prototype= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Prototype { get; set; }
    }
}