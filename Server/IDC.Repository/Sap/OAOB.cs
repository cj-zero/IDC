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
    public partial class OAOB 
    {
        public OAOB()
        {
          this.SendDate= DateTime.Now;
          this.WasSent= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SendDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SendTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WasSent { get; set; }
    }
}