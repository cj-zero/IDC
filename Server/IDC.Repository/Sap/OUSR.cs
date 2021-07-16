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
    public partial class OUSR 
    {
        public OUSR()
        {
          this.PASSWORD= string.Empty;
          this.PASSWORD1= string.Empty;
          this.PASSWORD2= string.Empty;
          this.USER_CODE= string.Empty;
          this.U_NAME= string.Empty;
          this.PASSWORD4= string.Empty;
          this.ALLOWENCES= string.Empty;
          this.SUPERUSER= string.Empty;
          this.PASSWORD3= string.Empty;
          this.Info1File= string.Empty;
          this.Info2File= string.Empty;
          this.Info3File= string.Empty;
          this.Info4File= string.Empty;
          this.dType= string.Empty;
          this.E_Mail= string.Empty;
          this.PortNum= string.Empty;
          this.OutOfOffic= string.Empty;
          this.SendEMail= string.Empty;
          this.SendSMS= string.Empty;
          this.DfltsGroup= string.Empty;
          this.CashLimit= string.Empty;
          this.Fax= string.Empty;
          this.SendFax= string.Empty;
          this.Locked= string.Empty;
          this.OpenCdt= string.Empty;
          this.DsplyRates= string.Empty;
          this.AuImpRates= string.Empty;
          this.OpenDps= string.Empty;
          this.RcrFlag= string.Empty;
          this.CheckFiles= string.Empty;
          this.OpenCredit= string.Empty;
          this.WallPaper= string.Empty;
          this.AdvImagePr= string.Empty;
          this.ContactLog= string.Empty;
          this.LastWarned= DateTime.Now;
          this.ShowNewMsg= string.Empty;
          this.Picture= string.Empty;
          this.Position= string.Empty;
          this.Address= string.Empty;
          this.Country= string.Empty;
          this.Tel1= string.Empty;
          this.Tel2= string.Empty;
          this.GENDER= string.Empty;
          this.Birthday= DateTime.Now;
          this.EnbMenuFlt= string.Empty;
          this.objType= string.Empty;
          this.createDate= DateTime.Now;
          this.updateDate= DateTime.Now;
          this.OneLogPwd= string.Empty;
          this.lastLogin= DateTime.Now;
          this.LastPwds= string.Empty;
          this.LastPwds2= string.Empty;
          this.LastPwdSet= DateTime.Now;
          this.PwdNeverEx= string.Empty;
          this.LstLogoutD= DateTime.Now;
          this.LstPwdChB= string.Empty;
          this.RclFlag= string.Empty;
          this.MobileUser= string.Empty;
          this.MobileIMEI= string.Empty;
          this.PrsWkCntEb= string.Empty;
          this.STData= string.Empty;
          this.SupportUsr= string.Empty;
          this.DomainUser= string.Empty;
          this.CUSAgree= string.Empty;
          this.EmailSig= string.Empty;
          this.DigCrtPath= string.Empty;
          this.ShowNewTsk= string.Empty;
          this.IntgrtEb= string.Empty;
          this.AllBrnchF= string.Empty;
          this.EvtNotify= string.Empty;
          this.IgnDtOwn= string.Empty;
          this.EnterAsTab= string.Empty;
          this.DotAsSep= string.Empty;
          this.MouseOnly= string.Empty;
          this.SkinType= string.Empty;
          this.Font= string.Empty;
          this.NaturalPer= string.Empty;
          this.DPPStatus= string.Empty;
          this.AutoAsnBPL= string.Empty;
          this.EncryptIV= string.Empty;
          this.HandleEDoc= string.Empty;
          this.U_PRX_SID= string.Empty;
          this.U_PRX_Pwd= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PASSWORD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PASSWORD1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PASSWORD2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short INTERNAL_K { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string USER_CODE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_NAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GROUPS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PASSWORD4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ALLOWENCES { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SUPERUSER { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DISCOUNT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PASSWORD3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Info1File { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Info1Field { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Info2File { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Info2Field { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Info3File { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Info3Field { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Info4File { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Info4Field { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string dType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string E_Mail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PortNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OutOfOffic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendEMail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendSMS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltsGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CashLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxCashSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Fax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendFax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Department { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Branch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] UserPrefs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Language { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Charset { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpenCdt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CdtPrvDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DsplyRates { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AuImpRates { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpenDps { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RcrFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckFiles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpenCredit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreditDay1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreditDay2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WallPaper { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? WllPprDsp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AdvImagePr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ContactLog { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LastWarned { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? AlertPolFr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ScreenLock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowNewMsg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Picture { get; set; }
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
        public string Country { get; set; }
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
        public string GENDER { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Birthday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnbMenuFlt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string objType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? logInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? userSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? createDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? userSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? updateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OneLogPwd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? lastLogin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LastPwds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LastPwds2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LastPwdSet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FailedLog { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PwdNeverEx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SalesDisc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PurchDisc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LstLogoutD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LstLoginT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LstLogoutT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LstPwdChT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LstPwdChB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RclFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MobileUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MobileIMEI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrsWkCntEb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? SnapShotId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string STData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SupportUsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? NoSTPwdNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DomainUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CUSAgree { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmailSig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public short? TPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DigCrtPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowNewTsk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IntgrtEb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AllBrnchF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EvtNotify { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IgnDtOwn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnterAsTab { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DotAsSep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MouseOnly { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SkinType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Font { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FontSize { get; set; }
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
        public string AutoAsnBPL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HandleEDoc { get; set; }
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