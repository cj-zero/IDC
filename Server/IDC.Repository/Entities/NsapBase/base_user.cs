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
    public partial class base_user
    {
        public base_user()
        {
          this.user_nm= string.Empty;
          this.user_desc= string.Empty;
          this.log_nm= string.Empty;
          this.log_psd= string.Empty;
          this.telphone= string.Empty;
          this.tel_short= string.Empty;
          this.email= string.Empty;
          this.im_nm= string.Empty;
          this.rec_dt= DateTime.Now;
          this.log_dt= DateTime.Now;

        }


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public uint user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string user_nm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string user_desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string log_nm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string log_psd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public long mobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string telphone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string tel_short { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string im_nm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public bool valid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime rec_dt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime log_dt { get; set; }
    }
}