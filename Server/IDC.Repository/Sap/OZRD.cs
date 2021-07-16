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
    public partial class OZRD 
    {
        public OZRD()
        {
          this.DocDate= DateTime.Now;
          this.POSEquipNo= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string POSEquipNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ResetCntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SummaryCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OperCntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrossSale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PISSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? COFINSSum { get; set; }
    }
}