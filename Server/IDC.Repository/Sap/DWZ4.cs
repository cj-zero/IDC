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
    public partial class DWZ4 
    {
        public DWZ4()
        {
          this.CheckLine= string.Empty;
          this.ExeChkLine= string.Empty;
          this.CardCode= string.Empty;
          this.CardName= string.Empty;
          this.DocCur= string.Empty;
          this.DueDate= DateTime.Now;
          this.LastLvlDte= DateTime.Now;
          this.LastDunDte= DateTime.Now;
          this.NewLvlDate= DateTime.Now;
          this.DocAmntLC= string.Empty;
          this.DocAmntFC= string.Empty;
          this.OpenAmtLC= string.Empty;
          this.OpenAmtFC= string.Empty;
          this.IntAmntLC= string.Empty;
          this.IntAmntFC= string.Empty;
          this.InclAmntLC= string.Empty;
          this.InclAmntFC= string.Empty;
          this.FeeLC= string.Empty;
          this.FeeFC= string.Empty;
          this.AllTotalLC= string.Empty;
          this.AllTotalFC= string.Empty;
          this.AutoPost= string.Empty;
          this.LetterFrmt= string.Empty;
          this.GrpMethod= string.Empty;
          this.DocRate= string.Empty;
          this.FeeCurr= string.Empty;
          this.MinBalCurr= string.Empty;
          this.LvlUpdated= string.Empty;
          this.DunAddr= string.Empty;
          this.DocText= string.Empty;
          this.BpCode2= string.Empty;
          this.BpType= string.Empty;
          this.CardName2= string.Empty;
          this.Comment= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExeChkLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LetterNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DunnLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocCur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? InstlmntID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LastLvlDte { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LastDunDte { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? NewLvlDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocAmntLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpenAmtLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpenAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IntrstDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IntrstPC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IntAmntLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IntAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InclAmntLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InclAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FeeLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FeeFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AllTotalLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AllTotalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoPost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LineProp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? YearDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? YearlyRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LetterFrmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinBlan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GrpMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FeeCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrigFee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MinBalCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LvlUpdated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DunAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocText { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? ParentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpCode2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? BPLId { get; set; }
    }
}