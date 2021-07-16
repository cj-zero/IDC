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
    public partial class DPO20 
    {
        public DPO20()
        {
          this.DistribM= string.Empty;
          this.ObjectType= string.Empty;
          this.FixCurr= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExpnsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DistribM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DrawnLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DrawnFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DrawnSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseLnNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FixCurr { get; set; }
    }
}