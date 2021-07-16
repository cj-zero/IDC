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
    public partial class OSTS 
    {
        public OSTS()
        {
          this.Choice= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Technician { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Choice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? GroupCode { get; set; }
    }
}