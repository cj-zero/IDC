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
    public partial class OACT 
    {
        public OACT()
        {
          this.AcctName= string.Empty;
          this.Finanse= string.Empty;
          this.Groups= string.Empty;
          this.Budget= string.Empty;
          this.Frozen= string.Empty;
          this.Free_2= string.Empty;
          this.Postable= string.Empty;
          this.Fixed= string.Empty;
          this.ExportCode= string.Empty;
          this.FatherNum= string.Empty;
          this.AccntntCod= string.Empty;
          this.CashBox= string.Empty;
          this.RateTrans= string.Empty;
          this.TaxIncome= string.Empty;
          this.ExmIncome= string.Empty;
          this.ActType= string.Empty;
          this.Transfered= string.Empty;
          this.BlncTrnsfr= string.Empty;
          this.OverType= string.Empty;
          this.OverCode= string.Empty;
          this.PrevYear= string.Empty;
          this.ActCurr= string.Empty;
          this.RateDifAct= string.Empty;
          this.Protected= string.Empty;
          this.RealAcct= string.Empty;
          this.Advance= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.FrgnName= string.Empty;
          this.Details= string.Empty;
          this.Project= string.Empty;
          this.RevalMatch= string.Empty;
          this.DataSource= string.Empty;
          this.LocMth= string.Empty;
          this.LocManTran= string.Empty;
          this.ObjType= string.Empty;
          this.ValidFor= string.Empty;
          this.ValidFrom= DateTime.Now;
          this.ValidTo= DateTime.Now;
          this.ValidComm= string.Empty;
          this.FrozenFor= string.Empty;
          this.FrozenFrom= DateTime.Now;
          this.FrozenTo= DateTime.Now;
          this.FrozenComm= string.Empty;
          this.Segment_0= string.Empty;
          this.Segment_1= string.Empty;
          this.Segment_2= string.Empty;
          this.Segment_3= string.Empty;
          this.Segment_4= string.Empty;
          this.Segment_5= string.Empty;
          this.Segment_6= string.Empty;
          this.Segment_7= string.Empty;
          this.Segment_8= string.Empty;
          this.Segment_9= string.Empty;
          this.FormatCode= string.Empty;
          this.CfwRlvnt= string.Empty;
          this.ExchRate= string.Empty;
          this.RevalAcct= string.Empty;
          this.LastRevDat= DateTime.Now;
          this.DfltVat= string.Empty;
          this.VatChange= string.Empty;
          this.TransCode= string.Empty;
          this.OverCode5= string.Empty;
          this.OverCode2= string.Empty;
          this.OverCode3= string.Empty;
          this.OverCode4= string.Empty;
          this.DfltTax= string.Empty;
          this.TaxPostAcc= string.Empty;
          this.AcctStrLe= string.Empty;
          this.MeaUnit= string.Empty;
          this.BalDirect= string.Empty;
          this.PlngLevel= string.Empty;
          this.MultiLink= string.Empty;
          this.PrjRelvnt= string.Empty;
          this.Dim1Relvnt= string.Empty;
          this.Dim2Relvnt= string.Empty;
          this.Dim3Relvnt= string.Empty;
          this.Dim4Relvnt= string.Empty;
          this.Dim5Relvnt= string.Empty;
          this.AccrualTyp= string.Empty;
          this.DatevAcct= string.Empty;
          this.DatevAutoA= string.Empty;
          this.DatevFirst= string.Empty;
          this.PCN874Rpt= string.Empty;
          this.SCAdjust= string.Empty;
          this.BPLName= string.Empty;
          this.SubLedgerN= string.Empty;
          this.VATRegNum= string.Empty;
          this.ActId= string.Empty;
          this.ClosingAcc= string.Empty;
          this.PurpCode= string.Empty;
          this.RefCode= string.Empty;
          this.BlocManPos= string.Empty;
          this.PriAccCode= string.Empty;
          this.CstAccOnly= string.Empty;
          this.BalanceA= string.Empty;
          this.CemRelvnt= string.Empty;
          this.CemCode= string.Empty;
          this.StdActCode= string.Empty;
          this.TaxonCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CurrTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EndTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Finanse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Groups { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Budget { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Frozen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Free_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Postable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Fixed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Levels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExportCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? GrpLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FatherNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AccntntCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CashBox { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GroupMask { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RateTrans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxIncome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExmIncome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExtrMatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IntrMatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlncTrnsfr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OverType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OverCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SysMatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrevYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RateDifAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SysTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FcTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Protected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RealAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Advance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Details { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExtraSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevalMatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LocMth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MTHCounter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BNKCounter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LocManTran { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValidFor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValidFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValidTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValidComm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrozenFor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FrozenFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FrozenTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrozenComm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Counter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Segment_0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Segment_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Segment_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Segment_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Segment_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Segment_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Segment_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Segment_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Segment_8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Segment_9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FormatCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CfwRlvnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExchRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevalAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LastRevBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LastRevDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatChange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OverCode5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OverCode2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OverCode3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OverCode4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxPostAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctStrLe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MeaUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BalDirect { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PlngLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MultiLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrjRelvnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dim1Relvnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dim2Relvnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dim3Relvnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dim4Relvnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dim5Relvnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AccrualTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DatevAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DatevAutoA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DatevFirst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? SnapShotId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PCN874Rpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SCAdjust { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? BPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPLName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubLedgerN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VATRegNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string ActId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ClosingAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlocManPos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriAccCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstAccOnly { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AlloweFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AllowedTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BalanceA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RmrkTmpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CemRelvnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StdActCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxonCode { get; set; }
    }
}