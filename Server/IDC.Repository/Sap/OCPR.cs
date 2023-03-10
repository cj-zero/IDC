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
    public partial class OCPR 
    {
        public OCPR()
        {
          this.CardCode= string.Empty;
          this.Name= string.Empty;
          this.Position= string.Empty;
          this.Address= string.Empty;
          this.Tel1= string.Empty;
          this.Tel2= string.Empty;
          this.Cellolar= string.Empty;
          this.Fax= string.Empty;
          this.E_MailL= string.Empty;
          this.Pager= string.Empty;
          this.Notes1= string.Empty;
          this.Notes2= string.Empty;
          this.DataSource= string.Empty;
          this.Password= string.Empty;
          this.ObjType= string.Empty;
          this.BirthPlace= string.Empty;
          this.BirthDate= DateTime.Now;
          this.Gender= string.Empty;
          this.Profession= string.Empty;
          this.updateDate= DateTime.Now;
          this.Title= string.Empty;
          this.BirthCity= string.Empty;
          this.Active= string.Empty;
          this.FirstName= string.Empty;
          this.MiddleName= string.Empty;
          this.LastName= string.Empty;
          this.BirthState= string.Empty;
          this.ResidCity= string.Empty;
          this.ResidCntry= string.Empty;
          this.ResidState= string.Empty;
          this.NFeRcpn= string.Empty;
          this.EmlGrpCode= string.Empty;
          this.BlockComm= string.Empty;
          this.FiscalCode= string.Empty;
          this.CtyPrvsYr= string.Empty;
          this.SttPrvsYr= string.Empty;
          this.CtyCdPrvsY= string.Empty;
          this.CtyCurYr= string.Empty;
          this.SttCurYr= string.Empty;
          this.CtyCdCurYr= string.Empty;
          this.NotResdSch= string.Empty;
          this.CtyFsnCode= string.Empty;
          this.NaturalPer= string.Empty;
          this.DPPStatus= string.Empty;
          this.CreateDate= DateTime.Now;
          this.EncryptIV= string.Empty;
          this.U_ACCT= string.Empty;
          this.U_BANK= string.Empty;
          this.U_PRX_SID= string.Empty;
          this.U_PRX_Pwd= string.Empty;
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
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Tel1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Tel2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Cellolar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Fax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string E_MailL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Pager { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Notes1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Notes2 { get; set; }
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
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BirthPlace { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BirthDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Profession { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? updateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? updateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BirthCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MiddleName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BirthState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResidCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResidCntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResidState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NFeRcpn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmlGrpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockComm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FiscalCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CtyPrvsYr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SttPrvsYr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CtyCdPrvsY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CtyCurYr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SttCurYr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CtyCdCurYr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NotResdSch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CtyFsnCode { get; set; }
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
        public string EncryptIV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ACCT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_BANK { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_SID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_Pwd { get; set; }
    }
}