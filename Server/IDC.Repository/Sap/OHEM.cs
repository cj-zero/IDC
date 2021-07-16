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
    public partial class OHEM 
    {
        public OHEM()
        {
          this.lastName= string.Empty;
          this.firstName= string.Empty;
          this.middleName= string.Empty;
          this.sex= string.Empty;
          this.jobTitle= string.Empty;
          this.workStreet= string.Empty;
          this.workBlock= string.Empty;
          this.workZip= string.Empty;
          this.workCity= string.Empty;
          this.workCounty= string.Empty;
          this.workCountr= string.Empty;
          this.workState= string.Empty;
          this.officeTel= string.Empty;
          this.officeExt= string.Empty;
          this.mobile= string.Empty;
          this.pager= string.Empty;
          this.homeTel= string.Empty;
          this.fax= string.Empty;
          this.email= string.Empty;
          this.startDate= DateTime.Now;
          this.salaryUnit= string.Empty;
          this.empCostUnt= string.Empty;
          this.termDate= DateTime.Now;
          this.bankCode= string.Empty;
          this.bankBranch= string.Empty;
          this.bankBranNo= string.Empty;
          this.bankAcount= string.Empty;
          this.homeStreet= string.Empty;
          this.homeBlock= string.Empty;
          this.homeZip= string.Empty;
          this.homeCity= string.Empty;
          this.homeCounty= string.Empty;
          this.homeCountr= string.Empty;
          this.homeState= string.Empty;
          this.birthDate= DateTime.Now;
          this.brthCountr= string.Empty;
          this.martStatus= string.Empty;
          this.govID= string.Empty;
          this.citizenshp= string.Empty;
          this.passportNo= string.Empty;
          this.passportEx= DateTime.Now;
          this.picture= string.Empty;
          this.remark= string.Empty;
          this.attachment= string.Empty;
          this.salaryCurr= string.Empty;
          this.empCostCur= string.Empty;
          this.WorkBuild= string.Empty;
          this.HomeBuild= string.Empty;
          this.AddrTypeW= string.Empty;
          this.AddrTypeH= string.Empty;
          this.StreetNoW= string.Empty;
          this.StreetNoH= string.Empty;
          this.DispMidNam= string.Empty;
          this.NamePos= string.Empty;
          this.DispComma= string.Empty;
          this.CostCenter= string.Empty;
          this.CompanyNum= string.Empty;
          this.MunKey= string.Empty;
          this.TaxClass= string.Empty;
          this.InTaxLiabi= string.Empty;
          this.EmTaxCCode= string.Empty;
          this.RelPartner= string.Empty;
          this.ExemptUnit= string.Empty;
          this.AddiUnit= string.Empty;
          this.TaxOName= string.Empty;
          this.TaxONum= string.Empty;
          this.HeaInsName= string.Empty;
          this.HeaInsCode= string.Empty;
          this.HeaInsType= string.Empty;
          this.SInsurNum= string.Empty;
          this.StatusOfP= string.Empty;
          this.StatusOfE= string.Empty;
          this.BCodeDateV= string.Empty;
          this.DevBAOwner= string.Empty;
          this.FNameSP= string.Empty;
          this.SurnameSP= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.PersGroup= string.Empty;
          this.JTCode= string.Empty;
          this.ExtEmpNo= string.Empty;
          this.BirthPlace= string.Empty;
          this.PymMeth= string.Empty;
          this.ExemptCurr= string.Empty;
          this.AddiCurr= string.Empty;
          this.FatherName= string.Empty;
          this.CPF= string.Empty;
          this.CRC= string.Empty;
          this.ContResp= string.Empty;
          this.RepLegal= string.Empty;
          this.DirfDeclar= string.Empty;
          this.UF_CRC= string.Empty;
          this.IDType= string.Empty;
          this.Active= string.Empty;
          this.ManualNUM= string.Empty;
          this.PassIssue= DateTime.Now;
          this.PassIssuer= string.Empty;
          this.QualCode= string.Empty;
          this.PRWebAccss= string.Empty;
          this.PrePRWeb= string.Empty;
          this.BPLink= string.Empty;
          this.NaturalPer= string.Empty;
          this.DPPStatus= string.Empty;
          this.EnRligion= string.Empty;
          this.EnRligionP= string.Empty;
          this.EncryptIV= string.Empty;
          this.EnGovID= string.Empty;
          this.EnPassport= string.Empty;
          this.CreateDate= DateTime.Now;
          this.EnInsurNum= string.Empty;
          this.EnBnkAcct= string.Empty;
          this.Code= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string lastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string firstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string middleName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string sex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string jobTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? dept { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? branch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string workStreet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string workBlock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string workZip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string workCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string workCounty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string workCountr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string workState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? manager { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? userId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? salesPrson { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string officeTel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string officeExt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string mobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string pager { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string homeTel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string fax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? startDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? salary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string salaryUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? emplCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string empCostUnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? termDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? termReason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string bankCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string bankBranch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string bankBranNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string bankAcount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string homeStreet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string homeBlock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string homeZip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string homeCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string homeCounty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string homeCountr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string homeState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? birthDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string brthCountr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string martStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? nChildren { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string govID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string citizenshp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string passportNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? passportEx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string picture { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string attachment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string salaryCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string empCostCur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WorkBuild { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HomeBuild { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrTypeW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrTypeH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetNoW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetNoH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DispMidNam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NamePos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DispComma { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostCenter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompanyNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VacPreYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VacCurYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MunKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxClass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InTaxLiabi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmTaxCCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RelPartner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExemptAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExemptUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AddiAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddiUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxOName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxONum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HeaInsName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HeaInsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HeaInsType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SInsurNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StatusOfP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StatusOfE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BCodeDateV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DevBAOwner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FNameSP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SurnameSP { get; set; }
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
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PersGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JTCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtEmpNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BirthPlace { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymMeth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExemptCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddiCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STDCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FatherName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CPF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CRC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ContResp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepLegal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DirfDeclar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UF_CRC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IDType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Active { get; set; }
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
        public string ManualNUM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PassIssue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PassIssuer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QualCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PRWebAccss { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrePRWeb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NaturalPer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPPStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnRligion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnRligionP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnGovID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnPassport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CreateTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UpdateTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnInsurNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnBnkAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code { get; set; }
    }
}