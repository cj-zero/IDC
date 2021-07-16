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
    public partial class ODAL 
    {
        public ODAL()
        {
          this.FormID= string.Empty;
          this.MobDesc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DashEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FormID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MobDesc { get; set; }
    }
}