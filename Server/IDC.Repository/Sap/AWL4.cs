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
    public partial class AWL4 
    {
        public AWL4()
        {
          this.WFInstID= string.Empty;
          this.ObjectType= string.Empty;
          this.ObjKey= string.Empty;
          this.OutParamID= string.Empty;
          this.ObjSubType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WFInstID { get; set; }
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
        public string OutParamID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjSubType { get; set; }
    }
}