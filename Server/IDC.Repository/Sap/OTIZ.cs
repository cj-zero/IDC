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
    public partial class OTIZ 
    {
        public OTIZ()
        {
          this.ChangeDate= string.Empty;
          this.ActiveDst= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChangeDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TimeZone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActiveDst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? offset { get; set; }
    }
}