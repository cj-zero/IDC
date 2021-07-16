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
    public partial class OMTC 
    {
        public OMTC()
        {
          this.MtcAlias= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short MatchID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short Round { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? MtcRule { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MtcAlias { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Differnce { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DiffAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short RuleIndex { get; set; }
    }
}