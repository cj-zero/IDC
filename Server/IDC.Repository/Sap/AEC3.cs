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
    public partial class AEC3 
    {
        public AEC3()
        {
          this.LogType= string.Empty;
          this.LogMessage= string.Empty;
          this.LogData= string.Empty;
          this.LogOpDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LogType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LogMessage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LogData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LogOpDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogOpTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExportFmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CreateTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UpdateTS { get; set; }
    }
}