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
    public partial class BNK1 
    {
        public BNK1()
        {
          this.DocID= string.Empty;
          this.IsDebit= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmntLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmnFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsDebit { get; set; }
    }
}