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
    public partial class OSRC 
    {
        public OSRC()
        {
          this.SysRptName= string.Empty;
          this.CusRptName= string.Empty;
          this.RptChoice= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SysRptName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] SysRptTemp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CusRptName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] CusRptTemp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RptChoice { get; set; }
    }
}