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
    public partial class MDC1 
    {
        public MDC1()
        {
          this.ObjectType= string.Empty;
          this.ObjectKey= string.Empty;
          this.Name= string.Empty;
          this.LastDate= DateTime.Now;
          this.Action= string.Empty;
          this.ObjectCode= string.Empty;
          this.ActFailed= string.Empty;
          this.OrigAction= string.Empty;
          this.SubObjType= string.Empty;
          this.SubObjKey= string.Empty;
          this.SubObjNam1= string.Empty;
          this.SubObjNam2= string.Empty;
          this.SubObjNam3= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LastDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActFailed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrigAction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubObjKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubObjNam1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubObjNam2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubObjNam3 { get; set; }
    }
}