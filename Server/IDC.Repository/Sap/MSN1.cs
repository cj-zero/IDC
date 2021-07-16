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
    public partial class MSN1 
    {
        public MSN1()
        {
          this.ReqSel= string.Empty;
          this.InvtSel= string.Empty;
          this.ExtIvntSel= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReqSel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvtSel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtIvntSel { get; set; }
    }
}