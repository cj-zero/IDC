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
    public partial class CASE1 
    {
        public CASE1()
        {
          this.ShortName= string.Empty;
          this.Account= string.Empty;
          this.InconsType= string.Empty;
          this.CredDeb= string.Empty;
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
        public string Account { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OrigAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OrigObjTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OrigDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OrigInsNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? OrigTrnsId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OrigTrnsLn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LnkRecnAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LnkRecnObj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LnkRecnNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LnkRecnIns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LnkRecnTrn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LnkRecnLn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InconsType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ReconNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NewRcnNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CredDeb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmountFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AmountSC { get; set; }
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
        public int? TransLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? X { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Y { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Z { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LnkObjAbsE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LinkObjTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LinkDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LinkInsNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? LinkTrnsId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LinkTrnsLn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TrnsTtlAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TrnsTtlFc { get; set; }
    }
}