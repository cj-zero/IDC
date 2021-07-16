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
    public partial class IPF1 
    {
        public IPF1()
        {
          this.ItemCode= string.Empty;
          this.Dscription= string.Empty;
          this.Currency= string.Empty;
          this.CardCode= string.Empty;
          this.Reference= string.Empty;
          this.CostOH= string.Empty;
          this.StockEval= string.Empty;
          this.UseBaseUn= string.Empty;
          this.BlockNum= string.Empty;
          this.ImportLog= string.Empty;
          this.WhsCode= string.Empty;
          this.Locked= string.Empty;
          this.OrigWhs= string.Empty;
          this.FobValCurr= string.Empty;
          this.Project= string.Empty;
          this.OcrCode= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.OriBDocTyp= string.Empty;
          this.VatGroup= string.Empty;
          this.SnbType= string.Empty;
          this.DistNumber= string.Empty;
          this.ExcInStk= string.Empty;
          this.CstmInStk= string.Empty;
          this.CstmVatStk= string.Empty;
          this.CCDNumber= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dscription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PriceFOB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Custom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CustomFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Cost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PriceAtWH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PricAtWHFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalFrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Volume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UnitCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Weight1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UnitCode1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Weight2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UnitCode2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Reference { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OrigLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FactNoCust { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FacWthCust { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PriceList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostOH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StockEval { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseBaseUn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ImportLog { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OrigRow { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrigWhs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ReleaseNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VarCosts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ConstCosts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VarCostsFR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CnstCostFR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UserCustom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UsrCusomFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FobValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FobValueFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlExpndLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlExpndFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlCustLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlCustFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlCostLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlCostFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlVolume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlWeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseRowNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlCustSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlExpndSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OriBAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OriBLinNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TargetDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FobValCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FobnLaC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FobnLaCFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NumPerMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OriBDocTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CustRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LFixCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LFixCostFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LVarCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LVarCostFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CstmsRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SnbType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SnbAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SysNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DistNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExciseSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExcisSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExcInStk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CustomSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CustSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstmInStk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CstmVatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CstmVatFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstmVatStk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CCDEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CCDNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExcisSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CustSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CstmVatSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InvQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CCDLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlVolCCM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExcImpQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExcFixAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExcRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExcAmntUoM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExcAmntAdV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExcImpQUoM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExcBasAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LineNumV3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FobVal2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FobVal2FC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}