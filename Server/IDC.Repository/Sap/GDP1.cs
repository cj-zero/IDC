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
    public partial class GDP1 
    {
        public GDP1()
        {
          this.TableName= string.Empty;
          this.FieldName= string.Empty;
          this.RefObjType= string.Empty;
          this.Category= string.Empty;
          this.OrigType= string.Empty;
          this.Type= string.Empty;
          this.Descr= string.Empty;
          this.MaxType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TableName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FieldName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrigType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MaxType { get; set; }
    }
}