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
    public partial class OWIN 
    {
        public OWIN()
        {
          this.ProcDefId= string.Empty;
          this.FlowElemId= string.Empty;
          this.InfoType= string.Empty;
          this.InfoCode= string.Empty;
          this.Desc= string.Empty;
          this.CreateDate= DateTime.Now;
          this.IsRead= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? WFInstId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TaskId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string ProcDefId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string FlowElemId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InfoType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InfoCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsRead { get; set; }
    }
}