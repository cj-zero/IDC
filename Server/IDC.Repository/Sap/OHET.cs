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
    public partial class OHET 
    {
        public OHET()
        {
          this.TransStart= DateTime.Now;
          this.TransEnd= DateTime.Now;
          this.Status= string.Empty;
          this.Comment= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TransStart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TransEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? StartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? EndTime { get; set; }
    }
}