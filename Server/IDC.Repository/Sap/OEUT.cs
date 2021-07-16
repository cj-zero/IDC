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
    public partial class OEUT 
    {
        public OEUT()
        {
          this.UnitCode= string.Empty;
          this.UnitName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UnitCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UnitName { get; set; }
    }
}