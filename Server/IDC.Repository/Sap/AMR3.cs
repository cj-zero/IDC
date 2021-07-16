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
    public partial class AMR3 
    {
        public AMR3()
        {
          this.SNBNum= string.Empty;
          this.AdmisDate= DateTime.Now;
          this.ExpiryDate= DateTime.Now;
          this.SnbLotNum= string.Empty;
          this.SnbMfn= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SNBNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? AdmisDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ExpiryDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CurrCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NewCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DebCred { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SNBOpenQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RToStock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SnbSysNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SnbAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SnbQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SnbCostT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SnbLotNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SnbMfn { get; set; }
    }
}