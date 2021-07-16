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
    public partial class ECDW1 
    {
        public ECDW1()
        {
          this.ExStrData1= string.Empty;
          this.ExStrData2= string.Empty;
          this.ExStrData3= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExNumData3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExStrData1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExStrData2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExStrData3 { get; set; }
    }
}