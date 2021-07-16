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
    public partial class OUTB 
    {
        public OUTB()
        {
          this.Descr= string.Empty;
          this.ObjectType= string.Empty;
          this.UsedInObj= string.Empty;
          this.LogTable= string.Empty;
          this.Archivable= string.Empty;
          this.ArchivDate= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TblNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UsedInObj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LogTable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Archivable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArchivDate { get; set; }
    }
}