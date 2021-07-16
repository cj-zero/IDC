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
    public partial class OBOD 
    {
        public OBOD()
        {
          this.BIOD_QN= string.Empty;
          this.BIOD_QLD= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BIOD_UID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BIOD_QID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BIOD_QN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BIOD_QLD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BIOD_QLT { get; set; }
    }
}