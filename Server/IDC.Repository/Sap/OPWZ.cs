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
    public partial class OPWZ 
    {
        public OPWZ()
        {
          this.PmntDate= DateTime.Now;
          this.NextDate= DateTime.Now;
          this.OutgoType= string.Empty;
          this.IncomType= string.Empty;
          this.CheckPmntM= string.Empty;
          this.BnkTrnsPmM= string.Empty;
          this.FilePath= string.Empty;
          this.PostDtFrom= DateTime.Now;
          this.PostDtTo= DateTime.Now;
          this.ValDteFrom= DateTime.Now;
          this.ValDateTo= DateTime.Now;
          this.Status= string.Empty;
          this.WizardName= string.Empty;
          this.StatusDisc= string.Empty;
          this.Canceled= string.Empty;
          this.BoePmnMn= string.Empty;
          this.ViewIntBal= string.Empty;
          this.SelMthd= string.Empty;
          this.MIDateFrom= DateTime.Now;
          this.MIDateTo= DateTime.Now;
          this.MIVDateFro= DateTime.Now;
          this.MIVDateTo= DateTime.Now;
          this.APDocDtFrm= DateTime.Now;
          this.APDocDtTo= DateTime.Now;
          this.APDueDtFrm= DateTime.Now;
          this.NxtPmntDat= DateTime.Now;
          this.ShowAtCard= string.Empty;
          this.NegBalBP= string.Empty;
          this.ManualJE= string.Empty;
          this.NegTrans= string.Empty;
          this.CDTransApp= string.Empty;
          this.BoeDDFrom= DateTime.Now;
          this.BoeDDTo= DateTime.Now;
          this.BoeStatus= string.Empty;
          this.HaExistBoe= string.Empty;
          this.SeqType= string.Empty;
          this.PayDueDate= string.Empty;
          this.CentrPay= string.Empty;
          this.ZeroBalBP= string.Empty;
          this.ZeroBalDoc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PmntDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? NextDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OutgoType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncomType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckPmntM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BnkTrnsPmM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FilePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDtFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDtTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValDteFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValDateTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApInvAmntF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApInvAmntT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PchNoFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PchNoTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InvNoFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InvNoTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SelPriorit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WizardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StatusDisc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Canceled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoePmnMn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SeriesOut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SeriesIn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalOut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalIn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ViewIntBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SelMthd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MINumFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MINumTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? MIDateFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? MIDateTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MIVNumFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MIVNumTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? MIVDateFro { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? MIVDateTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? APDocDtFrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? APDocDtTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? APDueDtFrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? NxtPmntDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinPayAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinPayAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowAtCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TolerDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinCashDis { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NegBalBP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManualJE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NegTrans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CDTransApp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CigTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CupFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CupTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CigFrom { get; set; }
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
        public System.DateTime? BoeDDFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BoeDDTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BoeNumFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BoeNumTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HaExistBoe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SeriesPOO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SeriesPOI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeqType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CentrPay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BA_AP_From { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BA_AP_To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BA_AR_From { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BA_AR_To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? JobId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ZeroBalBP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ZeroBalDoc { get; set; }
    }
}