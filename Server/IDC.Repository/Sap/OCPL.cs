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
    public partial class OCPL 
    {
        public OCPL()
        {
          this.StartDate= DateTime.Now;
          this.StartTime= string.Empty;
          this.EndDate= DateTime.Now;
          this.EndTime= string.Empty;
          this.CopySource= string.Empty;
          this.CopyTarget= string.Empty;
          this.UserName= string.Empty;
          this.MissingUDF= string.Empty;
          this.ErrorNum= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CopySource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CopyTarget { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CopyMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FailRpn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MissingUDF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CopyType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ErrorNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? NullifyAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CopyEmtVal { get; set; }
    }
}