using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDC.Repository.Entities.NsapBase
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("NsapBaseDbContext","NsapBaseReadDbContext")]
    public partial class sbo_user 
    {
        public sbo_user()
        {
          this.upd_dt= DateTime.Now;
        }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public uint sbo_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public uint user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? sale_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public uint tech_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime upd_dt { get; set; }
    }
}