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
    public partial class GPA8 
    {
        public GPA8()
        {
          this.ProdCode= string.Empty;
          this.ProdDescr= string.Empty;
          this.DistNumber= string.Empty;
          this.IncrAcct= string.Empty;
          this.DecrAcct= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProdCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProdDescr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DistNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SnBAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ManagedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncrAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DecrAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DebCredAmt { get; set; }
    }
}