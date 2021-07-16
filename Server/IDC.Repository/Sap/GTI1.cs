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
    public partial class GTI1 
    {
        public GTI1()
        {
          this.DisctLine= string.Empty;
          this.ItemName= string.Empty;
          this.ItemSpec= string.Empty;
          this.Uom= string.Empty;
          this.UnitPricTp= string.Empty;
          this.ItemTaxCat= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DisctLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemSpec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Uom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NetAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UnitPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UnitPricTp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemTaxCat { get; set; }
    }
}