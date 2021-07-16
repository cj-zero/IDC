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
    public partial class DRN1 
    {
        public DRN1()
        {
          this.AcctDtn= string.Empty;
          this.OrdDprAct= string.Empty;
          this.SpDprAct= string.Empty;
          this.SpBalAct= string.Empty;
          this.OrdBalAct= string.Empty;
          this.RevResAct= string.Empty;
          this.RevResClr= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctDtn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrdDprAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpDprAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpBalAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrdBalAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrdDprAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SpDprAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevResAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevResClr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RevReserve { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? CancelId { get; set; }
    }
}