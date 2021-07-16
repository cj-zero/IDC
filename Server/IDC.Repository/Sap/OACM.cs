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
    public partial class OACM 
    {
        public OACM()
        {
          this.CardCode= string.Empty;
          this.WTCode= string.Empty;
          this.PeriodCat= string.Empty;
          this.ExcdTransc= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
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
        public string WTCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PeriodCat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AcmAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExcdTransc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
    }
}