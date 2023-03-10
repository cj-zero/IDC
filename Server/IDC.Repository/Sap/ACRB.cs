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
    public partial class ACRB 
    {
        public ACRB()
        {
          this.CardCode= string.Empty;
          this.BankCode= string.Empty;
          this.Country= string.Empty;
          this.Account= string.Empty;
          this.Branch= string.Empty;
          this.Street= string.Empty;
          this.Block= string.Empty;
          this.ZipCode= string.Empty;
          this.City= string.Empty;
          this.County= string.Empty;
          this.State= string.Empty;
          this.ControlKey= string.Empty;
          this.UsrNumber1= string.Empty;
          this.UsrNumber2= string.Empty;
          this.UsrNumber3= string.Empty;
          this.UsrNumber4= string.Empty;
          this.IBAN= string.Empty;
          this.Building= string.Empty;
          this.AliasName= string.Empty;
          this.AcctType= string.Empty;
          this.BIK= string.Empty;
          this.AcctName= string.Empty;
          this.CorresAcct= string.Empty;
          this.Phone= string.Empty;
          this.Fax= string.Empty;
          this.ISRBillerI= string.Empty;
          this.CustIdNum= string.Empty;
          this.AddrType= string.Empty;
          this.StreetNo= string.Empty;
          this.SwiftNum= string.Empty;
          this.ABARoutNum= string.Empty;
          this.MandateID= string.Empty;
          this.SignDate= DateTime.Now;
          this.BranchChk= string.Empty;
          this.MandatDate= DateTime.Now;
          this.SeqType= string.Empty;
          this.ActType= string.Empty;
          this.IsPrenot= string.Empty;
          this.EnAccount= string.Empty;
          this.EnIBAN= string.Empty;
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
        public string BankCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Country { get; set; }
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
        public string State { get; set; }
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
        public string Building { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AliasName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BankKey { get; set; }
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
        public string SwiftNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ABARoutNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MandateID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SignDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PWZAbsEntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BranchChk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? MandatDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeqType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsPrenot { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnIBAN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}