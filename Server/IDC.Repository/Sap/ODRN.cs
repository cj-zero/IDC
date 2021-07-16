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
    public partial class ODRN 
    {
        public ODRN()
        {
          this.DprArea= string.Empty;
          this.Status= string.Empty;
          this.Canceled= string.Empty;
          this.RefDate= DateTime.Now;
          this.PeriodCat= string.Empty;
          this.KeyDate= DateTime.Now;
          this.Remarks= string.Empty;
          this.SumByPro= string.Empty;
          this.SumByDistr= string.Empty;
          this.TransType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DprArea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Canceled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PeriodCat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PostPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? KeyDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumOfJEs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumOfDpr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SumByPro { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SumByDistr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransAbs { get; set; }
    }
}