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
    public partial class ALT2 
    {
        public ALT2()
        {
          this.SendIntrnl= string.Empty;
          this.SendEMail= string.Empty;
          this.SendSMS= string.Empty;
          this.SendFax= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendIntrnl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendEMail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendSMS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendFax { get; set; }
    }
}