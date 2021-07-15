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
    public partial class base_post 
    {
        public base_post()
        {
          this.post_nm= string.Empty;
          this.post_desc= string.Empty;
          this.upd_dt= DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int post_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string post_nm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string post_desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public bool valid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime upd_dt { get; set; }
    }
}