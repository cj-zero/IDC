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
    public partial class TPS2 
    {
        public TPS2()
        {
          this.DispOrder= 0;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int DispOrder { get; set; }
    }
}