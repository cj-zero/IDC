﻿using System;
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
    public partial class OFLT 
    {
        public OFLT()
        {
          this.QueryStr= string.Empty;
          this.ItmOrCrd= string.Empty;
          this.CardInclud= string.Empty;
          this.CardFrom1= string.Empty;
          this.CardTo1= string.Empty;
          this.CardExclud= string.Empty;
          this.CardFrom2= string.Empty;
          this.CardTo2= string.Empty;
          this.ClntQryGrp= string.Empty;
          this.VeQryGroup= string.Empty;
          this.ItmInclud= string.Empty;
          this.ItmFrom1= string.Empty;
          this.ItmTo1= string.Empty;
          this.ItmExclud= string.Empty;
          this.ItmFrom2= string.Empty;
          this.ItmTo2= string.Empty;
          this.ItQryGroup= string.Empty;
          this.WhsInclude= string.Empty;
          this.WhsFrom1= string.Empty;
          this.WhsTo1= string.Empty;
          this.WhsExclude= string.Empty;
          this.WhsFrom2= string.Empty;
          this.WhsTo2= string.Empty;
          this.FromAcct= string.Empty;
          this.ToAcct= string.Empty;
          this.GroupMask= string.Empty;
          this.FromDate= DateTime.Now;
          this.ToDate= DateTime.Now;
          this.FrmDueDate= DateTime.Now;
          this.ToDueDate= DateTime.Now;
          this.FromDate3= DateTime.Now;
          this.ToDate3= DateTime.Now;
          this.FromDate4= DateTime.Now;
          this.ToDate4= DateTime.Now;
          this.FromRef1= string.Empty;
          this.ToRef1= string.Empty;
          this.FromRef2= string.Empty;
          this.ToRef2= string.Empty;
          this.FrmTrnsCod= string.Empty;
          this.ToTrnsCod= string.Empty;
          this.MemoIn= string.Empty;
          this.Break1= string.Empty;
          this.Break2= string.Empty;
          this.Break3= string.Empty;
          this.Display= string.Empty;
          this.PrntCutDat= string.Empty;
          this.CheckBox0= string.Empty;
          this.CheckBox1= string.Empty;
          this.CheckBox2= string.Empty;
          this.CheckBox3= string.Empty;
          this.CheckBox4= string.Empty;
          this.CheckBox5= string.Empty;
          this.CheckBox6= string.Empty;
          this.CheckBox7= string.Empty;
          this.CheckBox8= string.Empty;
          this.CheckBox9= string.Empty;
          this.ShowZero= string.Empty;
          this.DateCheck= string.Empty;
          this.DueCheck= string.Empty;
          this.CutCheck= string.Empty;
          this.CutByObj= string.Empty;
          this.ObjectC1= string.Empty;
          this.ObjectC2= string.Empty;
          this.ObjectC3= string.Empty;
          this.ObjectC4= string.Empty;
          this.ObjectC5= string.Empty;
          this.ObjectC6= string.Empty;
          this.ObjectC7= string.Empty;
          this.ObjectC8= string.Empty;
          this.ObjectC9= string.Empty;
          this.ObjectC10= string.Empty;
          this.ObjectC11= string.Empty;
          this.ObjectC12= string.Empty;
          this.ObjectC13= string.Empty;
          this.ObjectC14= string.Empty;
          this.ObjectC15= string.Empty;
          this.ObjectC16= string.Empty;
          this.USER_CHK1= string.Empty;
          this.USER_CHK2= string.Empty;
          this.USER_CHK3= string.Empty;
          this.USER_CHK4= string.Empty;
          this.USER_CHK5= string.Empty;
          this.UseSort= string.Empty;
          this.Sort1Up= string.Empty;
          this.Sort2Up= string.Empty;
          this.Sort3Up= string.Empty;
          this.TaxDateFro= DateTime.Now;
          this.TaxDateTo= DateTime.Now;
          this.FinancYear= DateTime.Now;
          this.CompFolder= string.Empty;
          this.CheckBox10= string.Empty;
          this.FCCurrency= string.Empty;
          this.TaxCheck= string.Empty;
          this.DateType= string.Empty;
          this.DateType2= string.Empty;
          this.FromPrject= string.Empty;
          this.ToProject= string.Empty;
          this.ShowLeads= string.Empty;
          this.MthDate= string.Empty;
          this.AccntntCod= string.Empty;
          this.BlcNunFrom= string.Empty;
          this.BlcNunTo= string.Empty;
          this.ImpLogFrom= string.Empty;
          this.ImpLogTo= string.Empty;
          this.FolderNum= string.Empty;
          this.TransMode= string.Empty;
          this.MonthMode= string.Empty;
          this.CheckBox11= string.Empty;
          this.FromIdc= string.Empty;
          this.ToIdc= string.Empty;
          this.IgnoreAdj= string.Empty;
          this.RefNumFrom= string.Empty;
          this.RefNumTo= string.Empty;
          this.BankFrom= string.Empty;
          this.BankTo= string.Empty;
          this.DpstType= string.Empty;
          this.ObjectC17= string.Empty;
          this.ObjectC18= string.Empty;
          this.ObjectC19= string.Empty;
          this.AddBTF= string.Empty;
          this.FilePath= string.Empty;
          this.DpsBnkActF= string.Empty;
          this.DpsBnkActT= string.Empty;
          this.ObjectC20= string.Empty;
          this.ObjectC21= string.Empty;
          this.ObjectC22= string.Empty;
          this.ObjectC23= string.Empty;
          this.ObjectC25= string.Empty;
          this.USER_CHK6= string.Empty;
          this.OcrChkDim2= string.Empty;
          this.OcrChkDim3= string.Empty;
          this.OcrChkDim4= string.Empty;
          this.OcrChkDim5= string.Empty;
          this.OcrFrom2= string.Empty;
          this.OcrFrom3= string.Empty;
          this.OcrFrom4= string.Empty;
          this.OcrFrom5= string.Empty;
          this.OcrTo2= string.Empty;
          this.OcrTo3= string.Empty;
          this.OcrTo4= string.Empty;
          this.OcrTo5= string.Empty;
          this.TaxAdjRep= string.Empty;
          this.ObjectC26= string.Empty;
          this.CBFilter= string.Empty;
          this.OBIncluded= string.Empty;
          this.OBFilter= string.Empty;
          this.ExportCurr= string.Empty;
          this.CBIncluded= string.Empty;
          this.SlpFrom= string.Empty;
          this.SlpTo= string.Empty;
          this.CBUDF= string.Empty;
          this.CBREF= string.Empty;
          this.CheckBoxB= string.Empty;
          this.BPFilter= string.Empty;
          this.AcctFltr= string.Empty;
          this.ZeroLCAmt= string.Empty;
          this.SplitByBin= string.Empty;
          this.SplitBySnb= string.Empty;
          this.CheckBox12= string.Empty;
          this.CheckBox13= string.Empty;
          this.CheckBox14= string.Empty;
          this.CheckBox15= string.Empty;
          this.CheckBox16= string.Empty;
          this.CheckBox17= string.Empty;
          this.CheckBox18= string.Empty;
          this.CheckBox19= string.Empty;
          this.CheckBox20= string.Empty;
          this.CheckBox21= string.Empty;
          this.CheckBox22= string.Empty;
          this.CheckBox23= string.Empty;
          this.CheckBox24= string.Empty;
          this.CheckBox25= string.Empty;
          this.CheckBox26= string.Empty;
          this.CheckBox27= string.Empty;
          this.CheckBox28= string.Empty;
          this.CheckBox29= string.Empty;
          this.CheckBox30= string.Empty;
          this.CheckBox31= string.Empty;
          this.CheckBox32= string.Empty;
          this.CheckBox33= string.Empty;
          this.BatchFrom= string.Empty;
          this.BatchTo= string.Empty;
          this.BatAttr1F= string.Empty;
          this.BatAttr1T= string.Empty;
          this.BatAttr2F= string.Empty;
          this.BatAttr2T= string.Empty;
          this.SerialNoF= string.Empty;
          this.SerialNoT= string.Empty;
          this.MfrSerailF= string.Empty;
          this.MfrSerailT= string.Empty;
          this.LotNumberF= string.Empty;
          this.LotNumberT= string.Empty;
          this.BinLocFrom= string.Empty;
          this.BinLocTo= string.Empty;
          this.AltSrtCodF= string.Empty;
          this.AltSrtCodT= string.Empty;
          this.BinSbl1F= string.Empty;
          this.BinSbl1To= string.Empty;
          this.BinSbl2F= string.Empty;
          this.BinSbl2To= string.Empty;
          this.BinSbl3F= string.Empty;
          this.BinSbl3To= string.Empty;
          this.BinSbl4F= string.Empty;
          this.BinSbl4To= string.Empty;
          this.BinAttr1F= string.Empty;
          this.BinAttr1To= string.Empty;
          this.BinAttr2F= string.Empty;
          this.BinAttr2To= string.Empty;
          this.BinAttr3F= string.Empty;
          this.BinAttr3To= string.Empty;
          this.BinAttr4F= string.Empty;
          this.BinAttr4To= string.Empty;
          this.BinAttr5F= string.Empty;
          this.BinAttr5To= string.Empty;
          this.BinAttr6F= string.Empty;
          this.BinAttr6To= string.Empty;
          this.BinAttr7F= string.Empty;
          this.BinAttr7To= string.Empty;
          this.BinAttr8F= string.Empty;
          this.BinAttr8To= string.Empty;
          this.BinAttr9F= string.Empty;
          this.BinAttr9To= string.Empty;
          this.BinAttr10F= string.Empty;
          this.BinAttr10T= string.Empty;
          this.EnfBinFltr= string.Empty;
          this.ExItemFrom= string.Empty;
          this.ExItemTo= string.Empty;
          this.ExBPFrom= string.Empty;
          this.ExBPTo= string.Empty;
          this.CheckBox34= string.Empty;
          this.CheckBox35= string.Empty;
          this.BlAgreem= string.Empty;
          this.BAFrom= string.Empty;
          this.BATo= string.Empty;
          this.AdjTrans= string.Empty;
          this.CCDFrom1= string.Empty;
          this.CCDTo1= string.Empty;
          this.CCDFrom2= string.Empty;
          this.CCDTo2= string.Empty;
          this.ArchJrnal= string.Empty;
          this.CardFrom3= string.Empty;
          this.CardTo3= string.Empty;
          this.OBBranch= string.Empty;
          this.AccumDbCr= string.Empty;
          this.RscFrom1= string.Empty;
          this.RscTo1= string.Empty;
          this.RouteStage= string.Empty;
          this.StgSeqNum= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QueryStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmOrCrd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardInclud { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardFrom1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardTo1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardExclud { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardFrom2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardTo2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ClienGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? VendGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ClntQryGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VeQryGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmInclud { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmFrom1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmTo1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmExclud { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmFrom2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmTo2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItmGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItQryGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsInclude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsFrom1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsTo1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsExclude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsFrom2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsTo2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupMask { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FromDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FrmDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FromDate3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToDate3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FromDate4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToDate4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FrmTrnsNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ToTrnsNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromRef1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToRef1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromRef2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToRef2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrmTrnsCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToTrnsCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FromSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ToSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FrmFRNAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ToFRNAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MemoIn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SortField1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Break1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SortField2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Break2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SortField3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Break3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Display { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrntCutDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowZero { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DateCheck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DueCheck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CutCheck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CutByObj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FromAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ToAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FrmSalsMan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ToSalsMan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string USER_CHK1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string USER_CHK2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string USER_CHK3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string USER_CHK4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string USER_CHK5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseSort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Sort1Up { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Sort2Up { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Sort3Up { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FromAmnt2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ToAmount2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDateFro { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDateTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FinancYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BdgtScenar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompFolder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FROM_FC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TO_FC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FCCurrency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCheck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DateType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DateType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromPrject { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToProject { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TemplateId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowLeads { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MthDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AccntntCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlcNunFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlcNunTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ImpLogFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ImpLogTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FolderNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? MainField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MonthMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string FromIdc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string ToIdc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IgnoreAdj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefNumFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefNumTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PymNumfrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PymNumTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DpstFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DpstTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpstType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ObjAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddBTF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FilePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpsBnkActF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpsBnkActT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FromKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ToKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string USER_CHK6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrChkDim2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrChkDim3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrChkDim4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrChkDim5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrFrom2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrFrom3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrFrom4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrFrom5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrTo2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrTo3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrTo4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrTo5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxAdjRep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectC26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CBFilter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OBIncluded { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OBFilter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExportCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CBIncluded { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SlpFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SlpTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CBUDF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CBREF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBoxB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? JDTFixedF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? JDT1FixedF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? JDTUserF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? JDT1UserF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPFilter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctFltr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ZeroLCAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SplitByBin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SplitBySnb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BatchFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BatchTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BatAttr1F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BatAttr1T { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BatAttr2F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BatAttr2T { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SerialNoF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SerialNoT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MfrSerailF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MfrSerailT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LotNumberF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LotNumberT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinLocFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinLocTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AltSrtCodF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AltSrtCodT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinSbl1F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinSbl1To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinSbl2F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinSbl2To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinSbl3F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinSbl3To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinSbl4F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinSbl4To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr1F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr1To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr2F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr2To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr3F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr3To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr4F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr4To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr5F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr5To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr6F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr6To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr7F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr7To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr8F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr8To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr9F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr9To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr10F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinAttr10T { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnfBinFltr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExItemFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExItemTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExBPFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExBPTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckBox35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlAgreem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BAFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BATo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AdjTrans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TitAcctLvl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CCDFrom1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CCDTo1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CCDFrom2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CCDTo2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ArchJrnal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardFrom3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardTo3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OBBranch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AccumDbCr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RscFrom1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RscTo1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RscGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RouteStage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExRSTFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExRSTTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StgSeqNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExSSNFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExSSNTo { get; set; }
    }
}