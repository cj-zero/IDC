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
    public partial class OCFX 
    {
        public OCFX()
        {
          this.ObjName= string.Empty;
          this.Group= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Group { get; set; }
    }
}