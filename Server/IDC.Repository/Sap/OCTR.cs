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
    public partial class OCTR 
    {
        public OCTR()
        {
          this.CstmrCode= string.Empty;
          this.CstmrName= string.Empty;
          this.Status= string.Empty;
          this.CntrcTmplt= string.Empty;
          this.CntrcType= string.Empty;
          this.Renewal= string.Empty;
          this.RemindUnit= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.ResponsUnt= string.Empty;
          this.Descriptio= string.Empty;
          this.SrcDocType= string.Empty;
          this.MonEnabled= string.Empty;
          this.TueEnabled= string.Empty;
          this.WedEnabled= string.Empty;
          this.ThuEnabled= string.Empty;
          this.FriEnabled= string.Empty;
          this.SatEnabled= string.Empty;
          this.SunEnabled= string.Empty;
          this.InclParts= string.Empty;
          this.InclWork= string.Empty;
          this.InclTravel= string.Empty;
          this.Attachment= string.Empty;
          this.CreateDate= DateTime.Now;
          this.Remarks1= string.Empty;
          this.Remarks2= string.Empty;
          this.RemindFlg= string.Empty;
          this.InclHldays= string.Empty;
          this.SrvcType= string.Empty;
          this.TermDate= DateTime.Now;
          this.ResponseU= string.Empty;
          this.Transfered= string.Empty;
          this.BPType= string.Empty;
          this.ObjType= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.DPPStatus= string.Empty;
          this.EncryptIV= string.Empty;
          this.U_PRX_SID= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstmrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstmrName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CntctCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntrcTmplt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntrcType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Renewal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RemindVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RemindUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Duration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ResponsVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResponsUnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descriptio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcDocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MonEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TueEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WedEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ThuEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FriEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SatEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SunEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? MonStart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? MonEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TueStart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TueEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? WedStart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? WedEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ThuStart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ThuEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FriStart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FriEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SatStart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SatEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SunStrart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SunEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InclParts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InclWork { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InclTravel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attachment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RemindFlg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CTR1Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RemTmDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ResTmHours { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InclHldays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrvcType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TermDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ResponseV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResponseU { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Instance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OwnerCode { get; set; }
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
        public System.DateTime? UpdateDate { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_SID { get; set; }
    }
}