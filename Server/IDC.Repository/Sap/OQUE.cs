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
    public partial class OQUE 
    {
        public OQUE()
        {
          this.descript= string.Empty;
          this.email= string.Empty;
          this.inactive= string.Empty;
          this.U_PRX_SID= string.Empty;
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
        public int? manager { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string inactive { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_SID { get; set; }
    }
}