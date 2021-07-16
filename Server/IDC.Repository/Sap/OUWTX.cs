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
    public partial class OUWTX 
    {
        public OUWTX()
        {
          this.SrcObjType= string.Empty;
          this.SrcObjAbs= 0;
          this.Cancelled= string.Empty;
          this.FullCopied= string.Empty;
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
        public int SrcObjAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Cancelled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FullCopied { get; set; }
    }
}