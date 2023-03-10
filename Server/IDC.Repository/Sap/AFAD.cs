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
    public partial class AFAD 
    {
        public AFAD()
        {
          this.DocNum= 0;
          this.PeriodCat= string.Empty;
          this.PostDate= DateTime.Now;
          this.DocDate= DateTime.Now;
          this.DocStatus= string.Empty;
          this.Comments= string.Empty;
          this.Reference= string.Empty;
          this.Currency= string.Empty;
          this.PIndicator= string.Empty;
          this.DataSource= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.TransType= string.Empty;
          this.JrnlMemo= string.Empty;
          this.AssetDate= DateTime.Now;
          this.CurSource= string.Empty;
          this.DocType= string.Empty;
          this.PrjSmarz= string.Empty;
          this.DstRlSmarz= string.Empty;
          this.ManDprType= string.Empty;
          this.Handwrtten= string.Empty;
          this.CancelDate= DateTime.Now;
          this.DprArea= string.Empty;
          this.BaseRef= string.Empty;
          this.LVARetire= string.Empty;
          this.BPLName= string.Empty;
          this.VatRegNum= string.Empty;
          this.GdsMovType= string.Empty;
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
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PeriodCat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FinncPriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Reference { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SysRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PIndicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotalSy { get; set; }
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
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JrnlMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? AssetDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CurSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrjSmarz { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DstRlSmarz { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManDprType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Handwrtten { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CancelDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DprArea { get; set; }
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
        public string BaseRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LVARetire { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CancelOpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPLName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatRegNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GdsMovType { get; set; }
    }
}