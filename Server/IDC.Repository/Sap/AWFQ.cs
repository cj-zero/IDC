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
    public partial class AWFQ 
    {
        public AWFQ()
        {
          this.SourceDB= string.Empty;
          this.Timestamp= string.Empty;
          this.ObjectType= string.Empty;
          this.TransType= string.Empty;
          this.FieldNames= string.Empty;
          this.FieldValue= string.Empty;
          this.UserID= string.Empty;
          this.TaskID= string.Empty;
          this.TrigEvntID= string.Empty;
          this.TrigParams= string.Empty;
          this.IsSuccess= string.Empty;
          this.ResultMemo= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SourceDB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Timestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FieldsInKe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FieldNames { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FieldValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaskID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrigEvntID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrigParams { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsSuccess { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResultMemo { get; set; }
    }
}