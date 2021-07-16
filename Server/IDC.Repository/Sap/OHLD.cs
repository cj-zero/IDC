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
    public partial class OHLD 
    {
        public OHLD()
        {
          this.WndFrm= string.Empty;
          this.WndTo= string.Empty;
          this.isCurYear= string.Empty;
          this.ignrWnd= string.Empty;
          this.WeekNoRule= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WndFrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WndTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string isCurYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ignrWnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WeekNoRule { get; set; }
    }
}