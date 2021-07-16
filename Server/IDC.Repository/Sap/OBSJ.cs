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
    public partial class OBSJ 
    {
        public OBSJ()
        {
          this.Type= string.Empty;
          this.Desc= string.Empty;
          this.Status= string.Empty;
          this.Schedule= string.Empty;
          this.NextDate= DateTime.Now;
          this.BFParams= string.Empty;
          this.EFParams= string.Empty;
          this.Message= string.Empty;
          this.RunType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Schedule { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? NextDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? NextTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BFParams { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EFParams { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BFRetry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EFRetry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RunAs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RunType { get; set; }
    }
}