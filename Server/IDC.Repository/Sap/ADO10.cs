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
    public partial class ADO10 
    {
        public ADO10()
        {
          this.LineType= string.Empty;
          this.LineText= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AftLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OrderNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineText { get; set; }
    }
}