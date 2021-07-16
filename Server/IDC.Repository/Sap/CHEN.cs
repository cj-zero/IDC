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
    public partial class CHEN 
    {
        public CHEN()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Counter { get; set; }
    }
}