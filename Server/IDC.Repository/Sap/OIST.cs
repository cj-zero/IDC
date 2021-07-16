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
    public partial class OIST 
    {
        public OIST()
        {
          this.InstrCode= string.Empty;
          this.InstrDespt= string.Empty;
          this.IsCancel= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InstrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InstrDespt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsCancel { get; set; }
    }
}