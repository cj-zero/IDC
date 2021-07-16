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
    public partial class AMD1 
    {
        public AMD1()
        {
          this.PmnDate= DateTime.Now;
          this.CardCode= string.Empty;
          this.InvType= string.Empty;
          this.FCCurrency= string.Empty;
          this.Approved= string.Empty;
          this.TMP_JE= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PmnDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InvEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public short? InstId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InvTransID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FCCurrency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InvRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PmnRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Approved { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmountDiff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxAmtDiff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TMP_JE { get; set; }
    }
}