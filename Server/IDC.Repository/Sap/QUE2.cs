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
    public partial class QUE2 
    {
        public QUE2()
        {
          this.objType= string.Empty;
          this.elementId= 0;
          this.createDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string objType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int elementId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? priority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? createDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? createTime { get; set; }
    }
}