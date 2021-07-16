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
    public partial class OISL 
    {
        public OISL()
        {
          this.TaskType= string.Empty;
          this.PatchLevel= string.Empty;
          this.FinishDate= DateTime.Now;
          this.UserCode= string.Empty;
          this.Status= string.Empty;
          this.InitMap= string.Empty;
          this.InitStd= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaskType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RunID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PatchLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LastMsgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FinishDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FinishTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InitMap { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InitStd { get; set; }
    }
}