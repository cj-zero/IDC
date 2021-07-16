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
    public partial class UDG4 
    {
        public UDG4()
        {
          this.ObjectCode= string.Empty;
          this.DocSubtype= string.Empty;
          this.DflPTICode= string.Empty;
          this.DflPtiFCE= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocSubtype { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflPTICode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflPtiFCE { get; set; }
    }
}