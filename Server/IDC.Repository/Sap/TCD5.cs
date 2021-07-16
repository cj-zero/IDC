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
    public partial class TCD5 
    {
        public TCD5()
        {
          this.TaxCode= string.Empty;
          this.Type= string.Empty;
          this.ExpTaxCode= string.Empty;
          this.PurTaxCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? Tcd3Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UsageCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpTaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurTaxCode { get; set; }
    }
}