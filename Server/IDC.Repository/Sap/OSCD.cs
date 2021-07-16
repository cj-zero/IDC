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
    public partial class OSCD 
    {
        public OSCD()
        {
          this.County= 0;
          this.ServiceCD= string.Empty;
          this.Descrip= string.Empty;
          this.Incomimg= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int County { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ServiceCD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descrip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Incomimg { get; set; }
    }
}