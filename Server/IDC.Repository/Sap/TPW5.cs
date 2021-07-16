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
    public partial class TPW5 
    {
        public TPW5()
        {
          this.ChlnDate= DateTime.Now;
          this.ChlnNo= string.Empty;
          this.ChlnBank= string.Empty;
          this.ChlnMemo= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ChlnDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChlnNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChlnBank { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChlnMemo { get; set; }
    }
}