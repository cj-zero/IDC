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
    public partial class RITM 
    {
        public RITM()
        {
          this.VISIBLE= string.Empty;
          this.SupZeros= string.Empty;
          this.FontName= string.Empty;
          this.ItemStr= string.Empty;
          this.FileName= string.Empty;
          this.FieldNum= string.Empty;
          this.ShowDescr= string.Empty;
          this.CalcType= string.Empty;
          this.RevOrder= string.Empty;
          this.IsUnique= string.Empty;
          this.IsGroup= string.Empty;
          this.NewPage= string.Empty;
          this.BarCode= string.Empty;
          this.Condition= string.Empty;
          this.LinkTo= string.Empty;
          this.SumInWords= string.Empty;
          this.ExcFonting= string.Empty;
          this.StrFiller= string.Empty;
          this.RelatedTo= string.Empty;
          this.NextSeg= string.Empty;
          this.HightAdjst= string.Empty;
          this.DupRpttAre= string.Empty;
          this.FieldId= string.Empty;
          this.FGEnabled= string.Empty;
          this.BGEnabled= string.Empty;
          this.MKEnabled= string.Empty;
          this.BDEnabled= string.Empty;
          this.HidEmpRptt= string.Empty;
          this.RpttFtrAll= string.Empty;
          this.GbiDataLen= string.Empty;
          this.IsLogo= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Container { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VISIBLE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SupZeros { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItemLeft { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItemTop { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LMargin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RMargin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TMargin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BMargin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LeftLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RightLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TopLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BottomLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Shadow { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BGRed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BGGreen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BGBlue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FGRed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FGGreen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FGBlue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MrkrRed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MrkrGreen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MrkrBlue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BrdrRed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BrdrGreen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BrdrBlue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FromPane { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ToPane { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItemGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FontName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FontSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TextStyle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Justific { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? WRAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PictSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? VarNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FieldNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowDescr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CalcType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ChangFlags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ApplID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CalcCol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? YJustific { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SortLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SortType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsUnique { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NewPage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BarCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Condition { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Operator1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Operator2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Operation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BCStandard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SumInWords { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExcFonting { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StrIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ContIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItemIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? StrLength { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StrFiller { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RelatedTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NextSeg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HightAdjst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DupRpttAre { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LnsRpttAre { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RptDupDist { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string FieldId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FGEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BGEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MKEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BDEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HidEmpRptt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RpttFtrAll { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GbiDataTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GbiDataLen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PageBreak { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsLogo { get; set; }
    }
}