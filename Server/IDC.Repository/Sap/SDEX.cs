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
    public partial class SDEX 
    {
        public SDEX()
        {
          this.BefAppl= string.Empty;
          this.AftAppl= string.Empty;
          this.BefScript= string.Empty;
          this.AftScript= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BefAppl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AftAppl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BefScript { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AftScript { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
    }
}