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
    public partial class ABO1 
    {
        public ABO1()
        {
          this.ExOpCode= string.Empty;
          this.OPDscrpt= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExOpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OPDscrpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InOpCode { get; set; }
    }
}