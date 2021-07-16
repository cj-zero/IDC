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
    public partial class ENT1 
    {
        public ENT1()
        {
          this.PurPackMsr= string.Empty;
          this.ArsnalName= string.Empty;
          this.ArsnalCode= string.Empty;
          this.UnitMsr= string.Empty;
          this.ItemCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PackQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurPackMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArsnalName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArsnalCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UnitMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Fraction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Weight1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
    }
}