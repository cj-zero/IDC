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
    public partial class ODIM 
    {
        public ODIM()
        {
          this.DimName= string.Empty;
          this.DimActive= string.Empty;
          this.DimDesc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DimName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DimActive { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DimDesc { get; set; }
    }
}