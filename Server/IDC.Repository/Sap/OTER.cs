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
    public partial class OTER 
    {
        public OTER()
        {
          this.descript= string.Empty;
          this.parent= 0;
          this.lindex= 0;
          this.inactive= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string descript { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int parent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int lindex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string inactive { get; set; }
    }
}