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
    public partial class OOAT 
    {
        public OOAT()
        {
          this.BpCode= string.Empty;
          this.BpName= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.TermDate= DateTime.Now;
          this.Descript= string.Empty;
          this.Type= string.Empty;
          this.Status= string.Empty;
          this.Renewal= string.Empty;
          this.UseDiscnt= string.Empty;
          this.RemindUnit= string.Empty;
          this.Remarks= string.Empty;
          this.UpdtDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.Cancelled= string.Empty;
          this.DataSource= string.Empty;
          this.Transfered= string.Empty;
          this.RemindFlg= string.Empty;
          this.Fulfilled= string.Empty;
          this.Attachment= string.Empty;
          this.Method= string.Empty;
          this.SignDate= DateTime.Now;
          this.Number= 0;
          this.ObjType= string.Empty;
          this.Handwrtten= string.Empty;
          this.PIndicator= string.Empty;
          this.BpType= string.Empty;
          this.PayMethod= string.Empty;
          this.NumAtCard= string.Empty;
          this.BPCurr= string.Empty;
          this.Project= string.Empty;
          this.PriceMode= string.Empty;
          this.WddStatus= string.Empty;
          this.FromStat= string.Empty;
          this.DPPStatus= string.Empty;
          this.SAPPassprt= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CntctCode { get; set; }
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
        public System.DateTime? TermDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descript { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Renewal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseDiscnt { get; set; }
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
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtchEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
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
        public System.DateTime? UpdtDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Cancelled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RemindFlg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Fulfilled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attachment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SettleProb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UpdtTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Method { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GroupNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ListNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SignDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AmendedTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int Number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Handwrtten { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PIndicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short Instance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NumAtCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FixedRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TrnspCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriceMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WddStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromStat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPPStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SAPPassprt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}