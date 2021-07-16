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
    public partial class RLS1 
    {
        public RLS1()
        {
          this.SrcObjType= string.Empty;
          this.SrcFld= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short SrcArr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcFld { get; set; }
    }
}