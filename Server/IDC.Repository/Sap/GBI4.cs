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
    public partial class GBI4 
    {
        public GBI4()
        {
          this.BPNo= string.Empty;
          this.BPName= string.Empty;
          this.Loc= string.Empty;
          this.Tel= string.Empty;
          this.Address= string.Empty;
          this.CreditRank= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CatNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Loc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Tel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreditRank { get; set; }
    }
}