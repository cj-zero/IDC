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
    public partial class ODGP 
    {
        public ODGP()
        {
          this.SetName= string.Empty;
          this.SetDesc= string.Empty;
          this.CreateDate= DateTime.Now;
          this.ModifyDate= DateTime.Now;
          this.Target= string.Empty;
          this.PostDate= DateTime.Now;
          this.TaxDate= DateTime.Now;
          this.Items= string.Empty;
          this.ItemSmmry= string.Empty;
          this.Service= string.Empty;
          this.ServSmmry= string.Empty;
          this.ExchgRate= string.Empty;
          this.CreatDraft= string.Empty;
          this.BaseQUT= string.Empty;
          this.BaseRDR= string.Empty;
          this.BaseDLN= string.Empty;
          this.BaseRDN= string.Empty;
          this.BaseResINV= string.Empty;
          this.ExpndSel= string.Empty;
          this.SortField= string.Empty;
          this.Consolidat= string.Empty;
          this.ExpandCons= string.Empty;
          this.RCNSummary= string.Empty;
          this.Direct= string.Empty;
          this.Indirect= string.Empty;
          this.DoReport= string.Empty;
          this.FileExport= string.Empty;
          this.SavePath= string.Empty;
          this.DealNum= string.Empty;
          this.UseDirect= string.Empty;
          this.NoItmCode= string.Empty;
          this.OnData= string.Empty;
          this.OnLedger= string.Empty;
          this.OnInvnt= string.Empty;
          this.Summary= string.Empty;
          this.AltItmDocs= string.Empty;
          this.PartDelivr= string.Empty;
          this.ConsiderBP= string.Empty;
          this.ConsiderTy= string.Empty;
          this.EDocGenTyp= string.Empty;
          this.EDocNum= string.Empty;
          this.ReopOriRdr= string.Empty;
          this.ReopManCls= string.Empty;
          this.UseBaseSeq= string.Empty;
          this.OnSeqCode= string.Empty;
          this.BlckFrOnly= string.Empty;
          this.DocSubType= string.Empty;
          this.EDocDflt= string.Empty;
          this.BsPrcMode= string.Empty;
          this.VatDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SetName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SetDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ModifyDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Target { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Items { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemSmmry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Service { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ServSmmry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExchgRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreatDraft { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseQUT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseRDR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseDLN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseRDN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseResINV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpndSel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SortField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Consolidat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpandCons { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RCNSummary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ChainCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OredrNum1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OredrNum2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Direct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Indirect { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DoReport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FileExport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SavePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DealNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseDirect { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NoItmCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OnData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OnLedger { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OnInvnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Summary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AltItmDocs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PartDelivr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ConsiderBP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ConsiderTy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocGenTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ESeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReopOriRdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReopManCls { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SeqCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseBaseSeq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OnSeqCode { get; set; }
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
        public string BlckFrOnly { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocSubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocDflt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BsPrcMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? VatDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EDocMapID { get; set; }
    }
}