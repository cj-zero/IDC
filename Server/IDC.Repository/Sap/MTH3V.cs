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
    public partial class MTH3V 
    {
        public MTH3V()
        {
          this.AcctCdeFrm= string.Empty;
          this.AcctCdeTo= string.Empty;
          this.IsCard= string.Empty;
          this.MthDateFrm= DateTime.Now;
          this.MthDateTo= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? absEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctCdeFrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctCdeTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MatchNumFr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MatchNumTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? MthDateFrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? MthDateTo { get; set; }
    }
}