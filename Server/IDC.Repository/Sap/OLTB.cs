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
    public partial class OLTB 
    {
        public OLTB()
        {
          this.STACode= string.Empty;
          this.BalaType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LocCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STAType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string STACode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BalaType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Balance { get; set; }
    }
}