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
    public partial class ISW3 
    {
        public ISW3()
        {
          this.ItemCode= string.Empty;
          this.RowStatus= string.Empty;
          this.CardCode= string.Empty;
          this.RecpType= string.Empty;
          this.DocBillDt= DateTime.Now;
          this.BPCtry= string.Empty;
          this.TaxCodeExt= string.Empty;
          this.NetMassSgn= string.Empty;
          this.NetMassUnt= string.Empty;
          this.SupMassSgn= string.Empty;
          this.SupplUnit= string.Empty;
          this.ValueSgn= string.Empty;
          this.FCCurrency= string.Empty;
          this.StatValSgn= string.Empty;
          this.ReturnID= string.Empty;
          this.Include= string.Empty;
          this.IsChanged= string.Empty;
          this.DstRegCry= string.Empty;
          this.DstRegSta= string.Empty;
          this.OriRegCry= string.Empty;
          this.OriRegSta= string.Empty;
          this.BpVATregNo= string.Empty;
          this.CtryOrig= string.Empty;
          this.Incoterms= string.Empty;
          this.NatOfTrans= string.Empty;
          this.TransMode= string.Empty;
          this.PortEnEx= string.Empty;
          this.CustProc= string.Empty;
          this.StatProc= string.Empty;
          this.DomFrgID= string.Empty;
          this.ItemType= string.Empty;
          this.CommCode= string.Empty;
          this.SerCode= string.Empty;
          this.SerSupplM= string.Empty;
          this.SerPymMeth= string.Empty;
          this.CorrDate= DateTime.Now;
          this.CorrSgn= string.Empty;
          this.ReferItem= string.Empty;
          this.ChgID= string.Empty;
          this.ChgUser= string.Empty;
          this.ChgTimest= DateTime.Now;
          this.Deleted= string.Empty;
          this.CstSecRc= string.Empty;
          this.CntryPay= string.Empty;
          this.Triangular= string.Empty;
          this.CardName= string.Empty;
          this.StatCode= string.Empty;
          this.Remarks= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RowStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RecpType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocBillDt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPCtry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCodeExt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NetMassSgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NetMass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NetMassUnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SupMassSgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SupplMass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SupplUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValueSgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ValueFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FCCurrency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StatValSgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StatVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReturnID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Include { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsChanged { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DstRegCry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DstRegSta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OriRegCry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OriRegSta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpVATregNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CtryOrig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Incoterms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NatOfTrans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PortEnEx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CustProc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StatProc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DomFrgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CommCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SerCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SerSupplM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SerPymMeth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CorrDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CorrSgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ReferDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ReferDocNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReferItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RefDocLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChgUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ChgTimest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Deleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstSecRc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CorrMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CorrYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CorrDeclNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CorRowNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DeclRowNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CorrType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntryPay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Triangular { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StatCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NetValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NetValueFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Freight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FreighFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RateFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ProtocolN { get; set; }
    }
}