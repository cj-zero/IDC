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
    public partial class GDP3 
    {
        public GDP3()
        {
          this.RefObjType= string.Empty;
          this.RefObjKey1= string.Empty;
          this.RefObjKey2= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefObjKey1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefObjKey2 { get; set; }
    }
}