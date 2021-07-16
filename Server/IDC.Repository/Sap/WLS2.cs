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
    public partial class WLS2 
    {
        public WLS2()
        {
          this.ObjectType= string.Empty;
          this.ObjKey= string.Empty;
          this.Command= string.Empty;
          this.ObjSubType= string.Empty;
          this.ObjDetail= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WFInstID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Command { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogIns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjSubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjDetail { get; set; }
    }
}