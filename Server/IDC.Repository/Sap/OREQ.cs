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
    public partial class OREQ 
    {
        public OREQ()
        {
          this.Status= string.Empty;
          this.CreateDate= DateTime.Now;
          this.LstUpdDate= DateTime.Now;
          this.UserSign= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LstUpdDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LstUpdTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Port { get; set; }
    }
}