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
    public partial class DSC1 
    {
        public DSC1()
        {
          this.BankCode= string.Empty;
          this.Account= string.Empty;
          this.Branch= string.Empty;
          this.GLAccount= string.Empty;
          this.Free= string.Empty;
          this.Street= string.Empty;
          this.Block= string.Empty;
          this.ZipCode= string.Empty;
          this.City= string.Empty;
          this.County= string.Empty;
          this.Country= string.Empty;
          this.State= string.Empty;
          this.BISR= string.Empty;
          this.ControlKey= string.Empty;
          this.UsrNumber1= string.Empty;
          this.UsrNumber2= string.Empty;
          this.UsrNumber3= string.Empty;
          this.UsrNumber4= string.Empty;
          this.IBAN= string.Empty;
          this.DscountBOE= string.Empty;
          this.BankCollec= string.Empty;
          this.BankDiscou= string.Empty;
          this.BranchName= string.Empty;
          this.AliasName= string.Empty;
          this.CompanyCod= string.Empty;
          this.AcctType= string.Empty;
          this.Building= string.Empty;
          this.BIK= string.Empty;
          this.AcctName= string.Empty;
          this.CorresAcct= string.Empty;
          this.Phone= string.Empty;
          this.Fax= string.Empty;
          this.GLIntriAct= string.Empty;
          this.ChkPaper= string.Empty;
          this.TmpltName= string.Empty;
          this.LockChk= string.Empty;
          this.AgreeNum= string.Empty;
          this.AccountChk= string.Empty;
          this.ISRBillerI= string.Empty;
          this.CustIdNum= string.Empty;
          this.FilePlug= string.Empty;
          this.ImpStmt= string.Empty;
          this.PreNumber= string.Empty;
          this.AddrType= string.Empty;
          this.StreetNo= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.SwiftNum= string.Empty;
          this.FineAcct= string.Empty;
          this.IntrstAcct= string.Empty;
          this.DscntAcct= string.Empty;
          this.SvcFeeAcct= string.Empty;
          this.BranchChk= string.Empty;
          this.RetFile= string.Empty;
          this.IOFTaxAcct= string.Empty;
          this.OthExpAcct= string.Empty;
          this.OthIncAcct= string.Empty;
          this.CollCode= string.Empty;
          this.RefCoLevel= string.Empty;
          this.Currency= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Account { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Branch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NextCheck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GLAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Free { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Street { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Block { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ZipCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string County { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BISR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ControlKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UsrNumber1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UsrNumber2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UsrNumber3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UsrNumber4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IBAN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DscountBOE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TolrnceDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinAmntBOE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxAmntBOE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DscntLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DaysInAdva { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCollec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankDiscou { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BranchName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AliasName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompanyCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Building { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BIK { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CorresAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Fax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GLIntriAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChkPaper { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? MaxChkLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TmpltName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BankKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LockChk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OurNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AgreeNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AccountChk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ISRType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISRBillerI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string CustIdNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InSeri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OutSeri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? JDTSeri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FilePlug { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ImpStmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PreNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UsrLogSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SwiftNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FineAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IntrstAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DscntAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SvcFeeAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BranchChk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RetFile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IOFTaxAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OthExpAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OthIncAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CollCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FileSeqNNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefCoLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RefFixLen1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RefFixLen2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
    }
}