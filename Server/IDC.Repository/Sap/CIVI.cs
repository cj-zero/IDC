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
    public partial class CIVI 
    {
        public CIVI()
        {
          this.EnableRun= string.Empty;
          this.EnblRunDt= DateTime.Now;
          this.IsOILMUpd= string.Empty;
          this.LstMsgDate= DateTime.Now;
          this.EnableUpd= string.Empty;
          this.IgnPreUpd= string.Empty;
          this.ForceRSP= string.Empty;
          this.ReorderFrm= DateTime.Now;
          this.ReorderTo= DateTime.Now;
          this.InitMap= string.Empty;
          this.InitStd= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnableRun { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EnblRunDt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MsgSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsOILMUpd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EnblDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LstChkMsg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LstMsgDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LstHndlMsg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnableUpd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IgnPreUpd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ForceRSP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ReorderFrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ReorderTo { get; set; }
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