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
    public partial class SOI3 
    {
        public SOI3()
        {
          this.CardCode= string.Empty;
          this.CardName= string.Empty;
          this.PayToCtry= string.Empty;
          this.PmntDate= DateTime.Now;
          this.RegNo= string.Empty;
          this.RegDate= DateTime.Now;
          this.ExecStat= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AgrNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AgrNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayToCtry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PmntNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PmntEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PmntType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PmntDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExcBasSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExciseSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatBaseSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RegNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RegDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExecStat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? BPLId { get; set; }
    }
}