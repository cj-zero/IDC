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
    public partial class ODUN 
    {
        public ODUN()
        {
          this.LetrFormat= string.Empty;
          this.EffctAftr= string.Empty;
          this.FeeCurr= string.Empty;
          this.MinBlnCurr= string.Empty;
          this.CalcIntert= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LetrFormat { get; set; }
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
        public string CalcIntert { get; set; }
    }
}