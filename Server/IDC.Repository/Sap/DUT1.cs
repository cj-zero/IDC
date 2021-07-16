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
    public partial class DUT1 
    {
        public DUT1()
        {
          this.LetterFrmt= string.Empty;
          this.EffctAftr= string.Empty;
          this.FeeCurr= string.Empty;
          this.MinBlnCurr= string.Empty;
          this.CalcIntrst= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LetterFrmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EffctAftr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LetterFee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FeeCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinBalance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MinBlnCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CalcIntrst { get; set; }
    }
}