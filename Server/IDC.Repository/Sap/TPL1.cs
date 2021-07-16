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
    public partial class TPL1 
    {
        public TPL1()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FieldPos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SrcArrType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SrcObjType { get; set; }
    }
}