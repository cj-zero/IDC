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
    public partial class EDG1 
    {
        public EDG1()
        {
          this.DiscType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DiscType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Discount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PayFor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ForFree { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UpTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
    }
}