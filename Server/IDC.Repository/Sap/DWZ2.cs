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
    public partial class DWZ2 
    {
        public DWZ2()
        {
          this.CardCode= string.Empty;
          this.FeeCurr= string.Empty;
          this.EDunLevel= string.Empty;
          this.OpnIntrCrr= string.Empty;
          this.IntrstCurr= string.Empty;
          this.ChckLine= string.Empty;
          this.DueDate= DateTime.Now;
          this.LetterLvl= string.Empty;
          this.OpenCurr= string.Empty;
          this.folioNum= string.Empty;
          this.LvlUpdated= string.Empty;
          this.ExeChkLine= string.Empty;
          this.AutoPost= string.Empty;
          this.BoEStatus= string.Empty;
          this.BoEDate= DateTime.Now;
          this.BPType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalFee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FeeCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlopnIntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDunLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpnIntrCrr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IntrstPC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IntrstAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IntrstCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChckLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IntrstDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LetterLvl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpenCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? sumIntrClc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string folioNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LvlUpdated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalFeeFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalFeeLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalFeeSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlopnInFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlopnInSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IntrAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IntrAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExeChkLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoPost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UnpaidBoEV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BoENumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoEStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BoEDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BoEKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? BPLId { get; set; }
    }
}