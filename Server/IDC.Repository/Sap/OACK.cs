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
    public partial class OACK 
    {
        public OACK()
        {
          this.FinYear= 0;
          this.Quarter= string.Empty;
          this.AckNum= string.Empty;
          this.Location= 0;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int FinYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Quarter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AckNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int Location { get; set; }
    }
}