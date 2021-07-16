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
    public partial class CTG1 
    {
        public CTG1()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short InstMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short InstDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InstPrcnt { get; set; }
    }
}