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
    public partial class PUTR1 
    {
        public PUTR1()
        {
          this.TestDesc= string.Empty;
          this.Result= string.Empty;
          this.BeginTime= string.Empty;
          this.EndTime= string.Empty;
          this.SAPNote= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TestDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BeginTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SAPNote { get; set; }
    }
}