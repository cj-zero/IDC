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
    public partial class OAMD 
    {
        public OAMD()
        {
          this.DateFrom= DateTime.Now;
          this.DateTo= DateTime.Now;
          this.CardCode= string.Empty;
          this.Approved= string.Empty;
          this.RpCurrency= string.Empty;
          this.VendOffAct= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
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
        public string RpCurrency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VendOffAct { get; set; }
    }
}