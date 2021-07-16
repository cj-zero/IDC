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
    public partial class OCMM 
    {
        public OCMM()
        {
          this.CommCode= string.Empty;
          this.CommDesc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CommCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CommDesc { get; set; }
    }
}