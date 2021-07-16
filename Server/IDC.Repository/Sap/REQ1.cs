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
    public partial class REQ1 
    {
        public REQ1()
        {
          this.MsgType= string.Empty;
          this.ErrCode= string.Empty;
          this.MsgBody= string.Empty;
          this.Status= string.Empty;
          this.MsgDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MsgType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ErrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MsgBody { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? MsgDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MsgTime { get; set; }
    }
}