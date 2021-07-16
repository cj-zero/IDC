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
    public partial class OWTS 
    {
        public OWTS()
        {
          this.Owner= string.Empty;
          this.OutputPar= string.Empty;
          this.EndTime= string.Empty;
          this.StartTime= string.Empty;
          this.Name= string.Empty;
          this.Desc= string.Empty;
          this.InputPar= string.Empty;
          this.DelReason= string.Empty;
          this.Assignee= string.Empty;
          this.LastUpdate= string.Empty;
          this.Key= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OutputPar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? ProcDefId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? ExeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? ProcInsId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InputPar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DelReason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Assignee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LastUpdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Key { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? B1Task { get; set; }
    }
}