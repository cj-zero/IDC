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
    public partial class SVM1 
    {
        public SVM1()
        {
          this.PropDesc= string.Empty;
          this.PropType= string.Empty;
          this.PropValue= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PropDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PropType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PropValue { get; set; }
    }
}