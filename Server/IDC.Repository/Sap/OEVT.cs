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
    public partial class OEVT 
    {
        public OEVT()
        {
          this.TypeCode= string.Empty;
          this.TypeName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TypeName { get; set; }
    }
}