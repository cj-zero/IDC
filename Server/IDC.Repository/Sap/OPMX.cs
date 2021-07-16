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
    public partial class OPMX 
    {
        public OPMX()
        {
          this.Currency= string.Empty;
          this.Uid= string.Empty;
          this.RFC= string.Empty;
          this.CreateDate= DateTime.Now;
          this.FileDate= DateTime.Now;
          this.FileName= string.Empty;
          this.Type= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Total { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Uid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FileDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? JVBatchNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? JVTransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? JETransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
    }
}