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
    public partial class RPRS 
    {
        public RPRS()
        {
          this.SeqName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeqName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ObjectID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SubDocType { get; set; }
    }
}