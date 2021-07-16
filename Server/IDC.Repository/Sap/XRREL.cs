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
    public partial class XRREL 
    {
        public XRREL()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RelType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SeqNo { get; set; }
    }
}