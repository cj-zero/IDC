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
    public partial class AJDT 
    {
        public AJDT()
        {
          this.BtfStatus= string.Empty;
          this.TransType= string.Empty;
          this.BaseRef= string.Empty;
          this.RefDate= DateTime.Now;
          this.Memo= string.Empty;
          this.Ref1= string.Empty;
          this.Ref2= string.Empty;
          this.TransCode= string.Empty;
          this.OrignCurr= string.Empty;
          this.TransCurr= string.Empty;
          this.Project= string.Empty;
          this.DueDate= DateTime.Now;
          this.TaxDate= DateTime.Now;
          this.PCAddition= string.Empty;
          this.DataSource= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.RefndRprt= string.Empty;
          this.ObjType= string.Empty;
          this.Indicator= string.Empty;
          this.AdjTran= string.Empty;
          this.RevSource= string.Empty;
          this.StornoDate= DateTime.Now;
          this.AutoStorno= string.Empty;
          this.Corisptivi= string.Empty;
          this.VatDate= DateTime.Now;
          this.StampTax= string.Empty;
          this.AutoVAT= string.Empty;
          this.FolioPref= string.Empty;
          this.BlockDunn= string.Empty;
          this.ReportEU= string.Empty;
          this.Report347= string.Empty;
          this.Printed= string.Empty;
          this.DocType= string.Empty;
          this.GenRegNo= string.Empty;
          this.Creator= string.Empty;
          this.Approver= string.Empty;
          this.SeriesStr= string.Empty;
          this.SubStr= string.Empty;
          this.AutoWT= string.Empty;
          this.VersionNum= string.Empty;
          this.ResidenNum= string.Empty;
          this.OperatCode= string.Empty;
          this.Ref3= string.Empty;
          this.SSIExmpt= string.Empty;
          this.SignMsg= string.Empty;
          this.SignDigest= string.Empty;
          this.CertifNum= string.Empty;
          this.SupplCode= string.Empty;
          this.DeferedTax= string.Empty;
          this.ECDPosTyp= string.Empty;
          this.RptPeriod= string.Empty;
          this.RptMonth= DateTime.Now;
          this.PrlLinked= string.Empty;
          this.PTICode= string.Empty;
          this.Letter= string.Empty;
          this.RepSection= string.Empty;
          this.ExclTaxRep= string.Empty;
          this.IsCoEntry= string.Empty;
          this.SAPPassprt= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BatchNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BtfStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Memo { get; set; }
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
        public int? CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LocTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FcTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SysTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrignCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TransRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BtfLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PCAddition { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FinncPriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
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
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefndRprt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Indicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AdjTran { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StornoDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StornoToTr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoStorno { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Corisptivi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? VatDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StampTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoVAT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocSeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FolioPref { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FolioNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockDunn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReportEU { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Report347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Printed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AttNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GenRegNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RG23APart2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RG23CPart2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MatType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Creator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Approver { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Location { get; set; }
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
        public string AutoWT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTApplied { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTAppliedS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTAppliedF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseVtAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseVtAtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseVtAtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VersionNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseTrans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResidenNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OperatCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SSIExmpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SignMsg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SignDigest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CertifNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? KeyVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CUP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CIG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SupplCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SPSrcType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SPSrcID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SPSrcDLN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeferedTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AgrNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SeqNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ECDPosTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RptPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RptMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? ExTransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrlLinked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PTICode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Letter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FolNumFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FolNumTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepSection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExclTaxRep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsCoEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SAPPassprt { get; set; }
    }
}