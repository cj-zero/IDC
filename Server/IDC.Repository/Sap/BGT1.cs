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
    public partial class BGT1 
    {
        public BGT1()
        {
          this.LineMemo= string.Empty;
          this.AcctCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DebLTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CredLTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DebSTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CredSTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DebRLTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CrdRLTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DebRSTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CrdRSTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FtrIDRLSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FtrIDRSSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FtrICRLSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FtrICRSSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FtrODRLSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FtrODRSSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FtrOCRLSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FtrOCRSSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MonthPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Instance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
    }
}