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
    public partial class ITR1 
    {
        public ITR1()
        {
          this.ShortName= string.Empty;
          this.SrcObjTyp= string.Empty;
          this.FrgnCurr= string.Empty;
          this.IsCredit= string.Empty;
          this.Account= string.Empty;
          this.MIType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShortName { get; set; }
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
        [Browsable(false)]
        public int? TransRowId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcObjTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SrcObjAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ReconSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ReconSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ReconSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumMthCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsCredit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Account { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CashDisSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? netBefDisc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MIEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MIType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InstID { get; set; }
    }
}