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
    public partial class OSRT 
    {
        public OSRT()
        {
          this.SumRptId= string.Empty;
          this.SumRptDate= DateTime.Now;
          this.FromDate= DateTime.Now;
          this.ToDate= DateTime.Now;
          this.RptType= string.Empty;
          this.version= string.Empty;
          this.SumSubId= string.Empty;
          this.SumRptType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string SumRptId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SumRptDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? BPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FromDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RptType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string SumSubId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SumRptType { get; set; }
    }
}