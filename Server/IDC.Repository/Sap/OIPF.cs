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
    public partial class OIPF 
    {
        public OIPF()
        {
          this.DocNum= 0;
          this.DocDate= DateTime.Now;
          this.DocDueDate= DateTime.Now;
          this.CardCode= string.Empty;
          this.SuppName= string.Empty;
          this.AgentCode= string.Empty;
          this.AgentName= string.Empty;
          this.DocStatus= string.Empty;
          this.AgentNum= string.Empty;
          this.Descr= string.Empty;
          this.Ref1= string.Empty;
          this.Ref2= string.Empty;
          this.DocCur= string.Empty;
          this.Canceled= string.Empty;
          this.CloseDate= DateTime.Now;
          this.BillOfLad= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.Transfered= string.Empty;
          this.TaxDate= DateTime.Now;
          this.Series= 0;
          this.JdtMemo= string.Empty;
          this.DataSource= string.Empty;
          this.ObjType= string.Empty;
          this.VersionNum= string.Empty;
          this.OpenForLaC= string.Empty;
          this.incCustom= string.Empty;
          this.SeriesStr= string.Empty;
          this.SubStr= string.Empty;
          this.BuildDesc= string.Empty;
          this.SupplCode= string.Empty;
          this.CustDate= DateTime.Now;
          this.DPPStatus= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SuppName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AgentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AgentName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AgentNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descr { get; set; }
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
        public string DocCur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpCustom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ActCustom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Vat1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Vat2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BeforeVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DocTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Canceled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExCustomFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AcCustomFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Vat1FC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Vat2FC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BeforVatFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CloseDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Cost_Match { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? C_Match_FC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BillOfLad { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TrnspCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CostFactor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short Instance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? JdtNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JdtMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExCustomSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ActCustSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlCostSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VersionNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpenForLaC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string incCustom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SeqCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Serial { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeriesStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BuildDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SupplCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CustDate { get; set; }
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
        public string DPPStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}