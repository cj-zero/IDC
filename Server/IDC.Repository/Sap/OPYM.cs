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
    public partial class OPYM 
    {
        public OPYM()
        {
          this.Descript= string.Empty;
          this.Type= string.Empty;
          this.BankTransf= string.Empty;
          this.Address= string.Empty;
          this.BankDet= string.Empty;
          this.CllctAutor= string.Empty;
          this.FrgnPmntBl= string.Empty;
          this.FrgnBnkBl= string.Empty;
          this.CurrRestr= string.Empty;
          this.PostOffBnk= string.Empty;
          this.BnkDflt= string.Empty;
          this.DataSource= string.Empty;
          this.CreateDate= DateTime.Now;
          this.BankCountr= string.Empty;
          this.DflAccount= string.Empty;
          this.GLAccount= string.Empty;
          this.Branch= string.Empty;
          this.KeyCode= string.Empty;
          this.TrnsType= string.Empty;
          this.Format= string.Empty;
          this.AgtCollect= string.Empty;
          this.SendAccept= string.Empty;
          this.GrpByDate= string.Empty;
          this.DepNorm= string.Empty;
          this.DebitMemo= string.Empty;
          this.GroupPmRef= string.Empty;
          this.GroupInv= string.Empty;
          this.ValDateSel= string.Empty;
          this.IntrimAcct= string.Empty;
          this.DocType= string.Empty;
          this.Accepted= string.Empty;
          this.PtfID= string.Empty;
          this.PtfCode= string.Empty;
          this.PtfNum= string.Empty;
          this.CurCode= string.Empty;
          this.Instruct1= string.Empty;
          this.Instruct2= string.Empty;
          this.PaymntPlc= string.Empty;
          this.BoeDll= string.Empty;
          this.BankCtlKey= string.Empty;
          this.Active= string.Empty;
          this.GrpByCur= string.Empty;
          this.GrpByBank= string.Empty;
          this.DflIBAN= string.Empty;
          this.DflSwift= string.Empty;
          this.BoeReport= string.Empty;
          this.CancInstr= string.Empty;
          this.OccurCode= string.Empty;
          this.MovmntCode= string.Empty;
          this.NegPymCode= string.Empty;
          this.DirectDbt= string.Empty;
          this.IssueIndic= string.Empty;
          this.PrintSEPA= string.Empty;
          this.PmntType= string.Empty;
          this.GrpByAgrNo= string.Empty;
          this.SpltPmtVAT= string.Empty;
        }

        
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
        public string BankTransf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankDet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CllctAutor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnPmntBl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnBnkBl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CurrRestr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PostOffBnk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BnkDflt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCountr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GLAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Branch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrnsType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Format { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AgtCollect { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendAccept { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GrpByDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DepNorm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DebitMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupPmRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValDateSel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PaymTerms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IntrimAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BnkActKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Accepted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PtfID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PtfCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PtfNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CurCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Instruct1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Instruct2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaymntPlc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeDll { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCtlKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BcgPcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GrpByCur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GrpByBank { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflIBAN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflSwift { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeReport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CancInstr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OccurCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MovmntCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NegPymCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DirectDbt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IssueIndic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrintSEPA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PmntType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GrpByAgrNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpltPmtVAT { get; set; }
    }
}