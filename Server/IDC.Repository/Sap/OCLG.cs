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
    public partial class OCLG 
    {
        public OCLG()
        {
          this.CardCode= string.Empty;
          this.Notes= string.Empty;
          this.CntctDate= DateTime.Now;
          this.Recontact= DateTime.Now;
          this.Closed= string.Empty;
          this.CloseDate= DateTime.Now;
          this.ContactPer= string.Empty;
          this.Tel= string.Empty;
          this.Fax= string.Empty;
          this.Transfered= string.Empty;
          this.DocType= string.Empty;
          this.DocNum= string.Empty;
          this.DocEntry= string.Empty;
          this.Attachment= string.Empty;
          this.DataSource= string.Empty;
          this.Action= string.Empty;
          this.Details= string.Empty;
          this.DurType= string.Empty;
          this.Priority= string.Empty;
          this.Reminder= string.Empty;
          this.RemType= string.Empty;
          this.RemDate= DateTime.Now;
          this.RemSented= string.Empty;
          this.endDate= DateTime.Now;
          this.personal= string.Empty;
          this.inactive= string.Empty;
          this.tentative= string.Empty;
          this.street= string.Empty;
          this.city= string.Empty;
          this.country= string.Empty;
          this.state= string.Empty;
          this.room= string.Empty;
          this.parentType= string.Empty;
          this.RecurPat= string.Empty;
          this.EndType= string.Empty;
          this.SeStartDat= DateTime.Now;
          this.SeEndDat= DateTime.Now;
          this.Sunday= string.Empty;
          this.Monday= string.Empty;
          this.Tuesday= string.Empty;
          this.Wednesday= string.Empty;
          this.Thursday= string.Empty;
          this.Friday= string.Empty;
          this.Saturday= string.Empty;
          this.SubOption= string.Empty;
          this.OrigDate= DateTime.Now;
          this.IsRemoved= string.Empty;
          this.LastRemind= DateTime.Now;
          this.AddrName= string.Empty;
          this.AddrType= string.Empty;
          this.NextDate= DateTime.Now;
          this.LaborItem= string.Empty;
          this.ResCode= string.Empty;
          this.FIPROJECT= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.DPPStatus= string.Empty;
          this.CreateDate= DateTime.Now;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Notes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CntctDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CntctTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Recontact { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Closed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CloseDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ContactPer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Tel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Fax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CntctSbjct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attachment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? AttendUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CntctCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SlpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Details { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CntctType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BeginTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Duration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DurType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ENDTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Priority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Reminder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RemQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RemType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? OprId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? OprLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RemDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RemTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RemSented { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Instance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? endDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string personal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string inactive { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string tentative { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string street { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string state { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string room { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string parentType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? parentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? prevActvty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RecurPat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EndType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SeStartDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SeEndDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MaxOccur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Interval { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Sunday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Monday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Tuesday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Wednesday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Thursday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Friday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Saturday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubOption { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DayInMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Month { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DayOfWeek { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Week { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SeriesNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? OrigDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsRemoved { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LastRemind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? AssignedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AttendEmpl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? NextDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? NextTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OwnerCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AttendReci { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LaborItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FIPROJECT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPPStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}