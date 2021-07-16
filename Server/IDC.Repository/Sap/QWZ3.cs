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
    public partial class QWZ3 
    {
        public QWZ3()
        {
          this.FileCode= string.Empty;
          this.FieldAlias= string.Empty;
          this.CondVal= string.Empty;
          this.CondEndVal= string.Empty;
          this.CompareFld= string.Empty;
          this.UseRes= string.Empty;
          this.CompTblIdx= string.Empty;
          this.CompFldNum= string.Empty;
          this.Free_Text= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OpenBrackt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FileCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FieldAlias { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Operation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CondVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CondEndVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompareFld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseRes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string CompTblIdx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompFldNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Relatship { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ClosBrackt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Free_Text { get; set; }
    }
}