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
    public partial class OGTY 
    {
        public OGTY()
        {
          this.GSTType= string.Empty;
          this.descrip= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GSTType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string descrip { get; set; }
    }
}