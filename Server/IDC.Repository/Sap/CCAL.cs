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
    public partial class CCAL 
    {
        public CCAL()
        {
          this.accLvlSet= string.Empty;
          this.balIndSet= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string accLvlSet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string balIndSet { get; set; }
    }
}