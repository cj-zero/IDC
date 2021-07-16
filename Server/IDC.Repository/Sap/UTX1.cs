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
    public partial class UTX1 
    {
        public UTX1()
        {
          this.TaxCode= string.Empty;
          this.StaCode= string.Empty;
          this.IsLiable= string.Empty;
          this.TaxType= string.Empty;
          this.IsAcq= string.Empty;
          this.Isdeferred= string.Empty;
          this.ValueDate= DateTime.Now;
          this.BaseObjTyp= string.Empty;
          this.TaxAcct= string.Empty;
          this.DefAcct= string.Empty;
          this.NdAcct= string.Empty;
          this.AcqAcct= string.Empty;
          this.ExpAcct= string.Empty;
          this.CrditDebit= string.Empty;
          this.PostingTyp= string.Empty;
          this.TransAcct= string.Empty;
          this.InPrice= string.Empty;
          this.Exempt= string.Empty;
          this.InGrossRev= string.Empty;
          this.PostStatus= string.Empty;
          this.IsItmLevel= string.Empty;
          this.EqTaxAcct= string.Empty;
          this.Reposted= string.Empty;
          this.Unencumbrd= string.Empty;
          this.IsSplitPay= string.Empty;
          this.SplitPayAc= string.Empty;
          this.TaxOnRI= string.Empty;
          this.GstPayAct= string.Empty;
          this.InFirstIns= string.Empty;
          this.GstRecvAct= string.Empty;
          this.IsCstmAct= string.Empty;
          this.CAOutCode= string.Empty;
          this.CAOutAcct= string.Empty;
          this.VatSumSrc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SrcArrType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SrcLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SrcGrpNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StaCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StaType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StaIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsLiable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsAcq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Isdeferred { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NdPercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EqPercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseObjTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseArrTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseLinNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseGrpNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseSumSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseSumFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSumSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSumFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DeductSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DedctSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DedctSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EqSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EqSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EqSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DefAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NdAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcqAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrditDebit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PostingTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BasePaid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BasePaidSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BasePaidFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPaid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPaidSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPaidFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DeductPaid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DdctPaidSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DdctPaidFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EqPaid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EqPaidSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EqPaidFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LnDataNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Exempt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InGrossRev { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PostStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsItmLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinTAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinTAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinTAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxTAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxTAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxTAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FlatTAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FlatTAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FlatTAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EqTaxAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Reposted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Unencumbrd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsSplitPay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SplitPayAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxOnRI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsChrgPrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsChrgSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsChrgSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsChrgFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GstPayAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsPaid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsPaidSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RvsPaidFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InFirstIns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GstRecvAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsCstmAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CAOutCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CABasSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CABasSumSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CABasSumFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CAVatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CAVatSumSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CAVatSumFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CAOutAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExtVatPcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExtVatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatSumSrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExtVatSumF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExtVatSumS { get; set; }
    }
}