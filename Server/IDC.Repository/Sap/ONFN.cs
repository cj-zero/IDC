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
    public partial class ONFN 
    {
        public ONFN()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AutoKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DfltSeq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UpdCounter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
    }
}