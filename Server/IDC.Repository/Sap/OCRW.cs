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
    public partial class OCRW 
    {
        public OCRW()
        {
          this.CardCode= string.Empty;
          this.SentMeth= string.Empty;
          this.LastAMeth= string.Empty;
          this.ReportID= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short Year { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SentMeth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SentValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LastAMeth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LastAValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReportID { get; set; }
    }
}