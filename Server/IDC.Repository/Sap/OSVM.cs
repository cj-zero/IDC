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
    public partial class OSVM 
    {
        public OSVM()
        {
          this.SysType= string.Empty;
          this.SysDsc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SysType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SysDsc { get; set; }
    }
}