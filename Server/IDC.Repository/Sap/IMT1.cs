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
    public partial class IMT1 
    {
        public IMT1()
        {
          this.DebitCredi= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DebitCredi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? OrderCalc { get; set; }
    }
}