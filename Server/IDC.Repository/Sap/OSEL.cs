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
    public partial class OSEL 
    {
        public OSEL()
        {
          this.FilterName= string.Empty;
          this.FormNum= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FilterName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FormNum { get; set; }
    }
}