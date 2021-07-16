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
    public partial class OILM 
    {
        public OILM()
        {
          this.LocCode= string.Empty;
          this.BaseCurr= string.Empty;
          this.Currency= string.Empty;
          this.DocDueDate= DateTime.Now;
          this.ItemCode= string.Empty;
          this.BPCardCode= string.Empty;
          this.DocDate= DateTime.Now;
          this.Comment= string.Empty;
          this.JrnlMemo= string.Empty;
          this.Ref1= string.Empty;
          this.Ref2= string.Empty;
          this.DataSource= string.Empty;
          this.CreateDate= DateTime.Now;
          this.OcrCode= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.CardName= string.Empty;
          this.Dscription= string.Empty;
          this.TreeType= string.Empty;
          this.AppObjType= string.Empty;
          this.BASE_REF= string.Empty;
          this.VersionNum= string.Empty;
          this.PriceCurr= string.Empty;
          this.PrjCode= string.Empty;
          this.TaxDate= DateTime.Now;
          this.UseDocPric= string.Empty;
          this.VendorNum= string.Empty;
          this.SerialNum= string.Empty;
          this.BlockNum= string.Empty;
          this.ImportLog= string.Empty;
          this.DocPrcCurr= string.Empty;
          this.CgsOcrCod= string.Empty;
          this.CgsOcrCod2= string.Empty;
          this.CgsOcrCod3= string.Empty;
          this.CgsOcrCod4= string.Empty;
          this.CgsOcrCod5= string.Empty;
          this.ExFromRpt= string.Empty;
          this.Ref3= string.Empty;
          this.EnSetCost= string.Empty;
          this.UseShpdGd= string.Empty;
          this.IsNegLnQty= string.Empty;
          this.StgDesc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EffectQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LocCode { get; set; }
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
        public string BaseCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AccumType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpensesLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpensesFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpensesSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPCardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JrnlMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SnBType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
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
        public decimal? DocPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dscription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TreeType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ApplObj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AppObjAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AppObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AppObjLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BASE_REF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransSeqRf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LayerIDRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VersionNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PriceRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriceCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CIShbQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SubLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrjCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SlpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseDocPric { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VendorNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SerialNum { get; set; }
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
        public int? Location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocPrcRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocPrcCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CgsOcrCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CgsOcrCod2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CgsOcrCod3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CgsOcrCod4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CgsOcrCod5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BSubLineNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AppSubLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SysRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExFromRpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnSetCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RetCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocAction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseShpdGd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AddTotalLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AddExpLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsNegLnQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StgSeqNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StgEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StgDesc { get; set; }
    }
}