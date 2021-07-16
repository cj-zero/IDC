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
    public partial class OWFER 
    {
        public OWFER()
        {
          this.MsgID= string.Empty;
          this.MsgDetails= string.Empty;
          this.CreateDate= DateTime.Now;
          this.MsgTaskID= string.Empty;
          this.MsgErrSrc= string.Empty;
          this.Remark= string.Empty;
          this.MsgType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MsgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MsgDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MsgTaskID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MsgErrSrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MsgType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MsgInstID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TemplateID { get; set; }
    }
}