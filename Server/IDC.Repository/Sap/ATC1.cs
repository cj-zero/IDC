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
    public partial class ATC1 
    {
        public ATC1()
        {
          this.srcPath= string.Empty;
          this.trgtPath= string.Empty;
          this.FileName= string.Empty;
          this.FileExt= string.Empty;
          this.Date= DateTime.Now;
          this.Copied= string.Empty;
          this.Override= string.Empty;
          this.subPath= string.Empty;
          this.FreeText= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string srcPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string trgtPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FileExt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UsrID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Copied { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Override { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string subPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeText { get; set; }
    }
}