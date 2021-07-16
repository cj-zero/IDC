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
    public partial class GPA4 
    {
        public GPA4()
        {
          this.LineType= string.Empty;
          this.CogsAcct= string.Empty;
          this.PrDiffAcct= string.Empty;
          this.AutoPost= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CurrCogs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CalcCogs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CogsDebit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CogsCredit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CogsAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrDiffAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoPost { get; set; }
    }
}