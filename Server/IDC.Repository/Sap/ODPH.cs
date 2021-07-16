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
    public partial class ODPH 
    {
        public ODPH()
        {
          this.UserSign= string.Empty;
          this.TmpltName= string.Empty;
          this.TmpltCnt= string.Empty;
          this.CrtDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TmpltName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TmpltCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CrtDate { get; set; }
    }
}