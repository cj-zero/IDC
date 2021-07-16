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
    public partial class SRA1 
    {
        public SRA1()
        {
          this.KeyString= string.Empty;
          this.KeyNumber= 0;
          this.ValString= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyString { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int KeyNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValString { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ValNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ValMoney { get; set; }
    }
}