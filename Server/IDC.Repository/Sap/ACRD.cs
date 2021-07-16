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
    public partial class ACRD 
    {
        public ACRD()
        {
          this.CardName= string.Empty;
          this.CardType= string.Empty;
          this.CmpPrivate= string.Empty;
          this.Address= string.Empty;
          this.ZipCode= string.Empty;
          this.MailAddres= string.Empty;
          this.MailZipCod= string.Empty;
          this.Phone1= string.Empty;
          this.Phone2= string.Empty;
          this.Fax= string.Empty;
          this.CntctPrsn= string.Empty;
          this.Notes= string.Empty;
          this.VatStatus= string.Empty;
          this.LicTradNum= string.Empty;
          this.DdctStatus= string.Empty;
          this.ValidUntil= DateTime.Now;
          this.Transfered= string.Empty;
          this.BalTrnsfrd= string.Empty;
          this.Free_Text= string.Empty;
          this.PrevYearAc= string.Empty;
          this.Currency= string.Empty;
          this.RateDifAct= string.Empty;
          this.Protected= string.Empty;
          this.Cellular= string.Empty;
          this.City= string.Empty;
          this.County= string.Empty;
          this.Country= string.Empty;
          this.MailCity= string.Empty;
          this.MailCounty= string.Empty;
          this.MailCountr= string.Empty;
          this.E_Mail= string.Empty;
          this.Picture= string.Empty;
          this.DflAccount= string.Empty;
          this.DflBranch= string.Empty;
          this.BankCode= string.Empty;
          this.AddID= string.Empty;
          this.Pager= string.Empty;
          this.FatherCard= string.Empty;
          this.CardFName= string.Empty;
          this.FatherType= string.Empty;
          this.QryGroup1= string.Empty;
          this.QryGroup2= string.Empty;
          this.QryGroup3= string.Empty;
          this.QryGroup4= string.Empty;
          this.QryGroup5= string.Empty;
          this.QryGroup6= string.Empty;
          this.QryGroup7= string.Empty;
          this.QryGroup8= string.Empty;
          this.QryGroup9= string.Empty;
          this.QryGroup10= string.Empty;
          this.QryGroup11= string.Empty;
          this.QryGroup12= string.Empty;
          this.QryGroup13= string.Empty;
          this.QryGroup14= string.Empty;
          this.QryGroup15= string.Empty;
          this.QryGroup16= string.Empty;
          this.QryGroup17= string.Empty;
          this.QryGroup18= string.Empty;
          this.QryGroup19= string.Empty;
          this.QryGroup20= string.Empty;
          this.QryGroup21= string.Empty;
          this.QryGroup22= string.Empty;
          this.QryGroup23= string.Empty;
          this.QryGroup24= string.Empty;
          this.QryGroup25= string.Empty;
          this.QryGroup26= string.Empty;
          this.QryGroup27= string.Empty;
          this.QryGroup28= string.Empty;
          this.QryGroup29= string.Empty;
          this.QryGroup30= string.Empty;
          this.QryGroup31= string.Empty;
          this.QryGroup32= string.Empty;
          this.QryGroup33= string.Empty;
          this.QryGroup34= string.Empty;
          this.QryGroup35= string.Empty;
          this.QryGroup36= string.Empty;
          this.QryGroup37= string.Empty;
          this.QryGroup38= string.Empty;
          this.QryGroup39= string.Empty;
          this.QryGroup40= string.Empty;
          this.QryGroup41= string.Empty;
          this.QryGroup42= string.Empty;
          this.QryGroup43= string.Empty;
          this.QryGroup44= string.Empty;
          this.QryGroup45= string.Empty;
          this.QryGroup46= string.Empty;
          this.QryGroup47= string.Empty;
          this.QryGroup48= string.Empty;
          this.QryGroup49= string.Empty;
          this.QryGroup50= string.Empty;
          this.QryGroup51= string.Empty;
          this.QryGroup52= string.Empty;
          this.QryGroup53= string.Empty;
          this.QryGroup54= string.Empty;
          this.QryGroup55= string.Empty;
          this.QryGroup56= string.Empty;
          this.QryGroup57= string.Empty;
          this.QryGroup58= string.Empty;
          this.QryGroup59= string.Empty;
          this.QryGroup60= string.Empty;
          this.QryGroup61= string.Empty;
          this.QryGroup62= string.Empty;
          this.QryGroup63= string.Empty;
          this.QryGroup64= string.Empty;
          this.DdctOffice= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.ExportCode= string.Empty;
          this.DscntRel= string.Empty;
          this.DdctFileNo= string.Empty;
          this.DataSource= string.Empty;
          this.ExemptNo= string.Empty;
          this.CrCardNum= string.Empty;
          this.CardValid= DateTime.Now;
          this.LocMth= string.Empty;
          this.validFor= string.Empty;
          this.validFrom= DateTime.Now;
          this.validTo= DateTime.Now;
          this.frozenFor= string.Empty;
          this.frozenFrom= DateTime.Now;
          this.frozenTo= DateTime.Now;
          this.sEmployed= string.Empty;
          this.ValidComm= string.Empty;
          this.FrozenComm= string.Empty;
          this.chainStore= string.Empty;
          this.DiscInRet= string.Empty;
          this.State1= string.Empty;
          this.State2= string.Empty;
          this.VatGroup= string.Empty;
          this.ObjType= string.Empty;
          this.Indicator= string.Empty;
          this.DebPayAcct= string.Empty;
          this.ShipToDef= string.Empty;
          this.Block= string.Empty;
          this.MailBlock= string.Empty;
          this.Password= string.Empty;
          this.ECVatGroup= string.Empty;
          this.Deleted= string.Empty;
          this.IBAN= string.Empty;
          this.DocEntry= 0;
          this.Box1099= string.Empty;
          this.PymCode= string.Empty;
          this.BackOrder= string.Empty;
          this.PartDelivr= string.Empty;
          this.DunnDate= DateTime.Now;
          this.BlockDunn= string.Empty;
          this.BankCountr= string.Empty;
          this.CollecAuth= string.Empty;
          this.DME= string.Empty;
          this.InstrucKey= string.Empty;
          this.SinglePaym= string.Empty;
          this.ISRBillId= string.Empty;
          this.PaymBlock= string.Empty;
          this.RefDetails= string.Empty;
          this.HouseBank= string.Empty;
          this.OwnerIdNum= string.Empty;
          this.HousBnkCry= string.Empty;
          this.HousBnkAct= string.Empty;
          this.HousBnkBrn= string.Empty;
          this.ProjectCod= string.Empty;
          this.VatIdUnCmp= string.Empty;
          this.AgentCode= string.Empty;
          this.SelfInvoic= string.Empty;
          this.DeferrTax= string.Empty;
          this.LetterNum= string.Empty;
          this.FromDate= DateTime.Now;
          this.ToDate= DateTime.Now;
          this.WTLiable= string.Empty;
          this.CrtfcateNO= string.Empty;
          this.ExpireDate= DateTime.Now;
          this.NINum= string.Empty;
          this.AccCritria= string.Empty;
          this.WTCode= string.Empty;
          this.Equ= string.Empty;
          this.HldCode= string.Empty;
          this.ConnBP= string.Empty;
          this.TypWTReprt= string.Empty;
          this.VATRegNum= string.Empty;
          this.RepName= string.Empty;
          this.Industry= string.Empty;
          this.Business= string.Empty;
          this.WTTaxCat= string.Empty;
          this.IsDomestic= string.Empty;
          this.IsResident= string.Empty;
          this.AutoCalBCG= string.Empty;
          this.OtrCtlAcct= string.Empty;
          this.AliasName= string.Empty;
          this.Building= string.Empty;
          this.MailBuildi= string.Empty;
          this.BoEPrsnt= string.Empty;
          this.BoEDiscnt= string.Empty;
          this.BoEOnClct= string.Empty;
          this.UnpaidBoE= string.Empty;
          this.ITWTCode= string.Empty;
          this.DunTerm= string.Empty;
          this.ChannlBP= string.Empty;
          this.BillToDef= string.Empty;
          this.DpmClear= string.Empty;
          this.IntrntSite= string.Empty;
          this.Profession= string.Empty;
          this.BCACode= string.Empty;
          this.UseShpdGd= string.Empty;
          this.RegNum= string.Empty;
          this.VerifNum= string.Empty;
          this.BankCtlKey= string.Empty;
          this.HousCtlKey= string.Empty;
          this.AddrType= string.Empty;
          this.InsurOp347= string.Empty;
          this.MailAddrTy= string.Empty;
          this.StreetNo= string.Empty;
          this.MailStrNo= string.Empty;
          this.TaxRndRule= string.Empty;
          this.ThreshOver= string.Empty;
          this.SurOver= string.Empty;
          this.VendorOcup= string.Empty;
          this.OpCode347= string.Empty;
          this.DpmIntAct= string.Empty;
          this.ResidenNum= string.Empty;
          this.PlngGroup= string.Empty;
          this.VatIDNum= string.Empty;
          this.Affiliate= string.Empty;
          this.MivzExpSts= string.Empty;
          this.HierchDdct= string.Empty;
          this.CertWHT= string.Empty;
          this.CertBKeep= string.Empty;
          this.WHShaamGrp= string.Empty;
          this.DatevAcct= string.Empty;
          this.DatevFirst= string.Empty;
          this.GTSRegNum= string.Empty;
          this.GTSBankAct= string.Empty;
          this.GTSBilAddr= string.Empty;
          this.HsBnkSwift= string.Empty;
          this.HsBnkIBAN= string.Empty;
          this.DflSwift= string.Empty;
          this.AutoPost= string.Empty;
          this.IntrAcc= string.Empty;
          this.FeeAcc= string.Empty;
          this.DflIBAN= string.Empty;
          this.TaxIdIdent= string.Empty;
          this.Attachment= string.Empty;
          this.DiscRel= string.Empty;
          this.NoDiscount= string.Empty;
          this.SCAdjust= string.Empty;
          this.GlblLocNum= string.Empty;
          this.SenderID= string.Empty;
          this.RcpntID= string.Empty;
          this.SefazCheck= string.Empty;
          this.free312= string.Empty;
          this.free313= string.Empty;
          this.DateFrom= DateTime.Now;
          this.DateTill= DateTime.Now;
          this.RelCode= string.Empty;
          this.OKATO= string.Empty;
          this.OKTMO= string.Empty;
          this.KBKCode= string.Empty;
          this.TypeOfOp= string.Empty;
          this.MandateID= string.Empty;
          this.SignDate= DateTime.Now;
          this.ConCerti= string.Empty;
          this.RoleTypCod= string.Empty;
          this.BlockComm= string.Empty;
          this.EmplymntCt= string.Empty;
          this.ExcptnlEvt= string.Empty;
          this.EdrsFromBP= string.Empty;
          this.EdrsToBP= string.Empty;
          this.EDocGenTyp= string.Empty;
          this.eStreet= string.Empty;
          this.eStreetNum= string.Empty;
          this.eZipCode= string.Empty;
          this.eCityTown= string.Empty;
          this.eCountry= string.Empty;
          this.eDistrict= string.Empty;
          this.RepFName= string.Empty;
          this.RepSName= string.Empty;
          this.RepCmpName= string.Empty;
          this.RepFisCode= string.Empty;
          this.RepAddID= string.Empty;
          this.PECAddr= string.Empty;
          this.IPACodePA= string.Empty;
          this.PriceMode= string.Empty;
          this.EffecPrice= string.Empty;
          this.TxExMxVdTp= string.Empty;
          this.MerchantID= string.Empty;
          this.UseBilAddr= string.Empty;
          this.NaturalPer= string.Empty;
          this.DPPStatus= string.Empty;
          this.EnAddID= string.Empty;
          this.EncryptIV= string.Empty;
          this.EnDflAccnt= string.Empty;
          this.EnDflIBAN= string.Empty;
          this.EnERD4In= string.Empty;
          this.EnERD4Out= string.Empty;
          this.DflCustomr= string.Empty;
          this.FCERelevnt= string.Empty;
          this.FCEVldte= string.Empty;
          this.U_PYSX= string.Empty;
          this.U_Name= string.Empty;
          this.U_FName= string.Empty;
          this.U_job_id= string.Empty;
          this.U_FPLB= string.Empty;
          this.U_Prefix= string.Empty;
          this.U_Suffix= string.Empty;
          this.U_is_reseller= string.Empty;
          this.U_EndCustomerName= string.Empty;
          this.U_EndCustomerContact= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GroupCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CmpPrivate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ZipCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MailAddres { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MailZipCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Phone1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Phone2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Fax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntctPrsn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Notes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Balance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ChecksBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DNotesBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrdersBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GroupNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CreditLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DebtLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Discount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LicTradNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DdctStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DdctPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValidUntil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Chrctrstcs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExMatchNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InMatchNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ListNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DNoteBalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrderBalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DNoteBalSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrderBalSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BalTrnsfrd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IntrstRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Commission { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CommGrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Free_Text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SlpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrevYearAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RateDifAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BalanceSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BalanceFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Protected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Cellular { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? AvrageLate { get; set; }
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
        public string MailCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MailCounty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MailCountr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string E_Mail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Picture { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflBranch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Pager { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FatherCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardFName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FatherType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DdctOffice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExportCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DscntObjct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DscntRel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SPGCounter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SPPCounter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DdctFileNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SCNCounter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinIntrst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OprCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExemptNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Priority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreditCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrCardNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CardValid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LocMth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string validFor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? validFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? validTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string frozenFor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? frozenFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? frozenTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string sEmployed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MTHCounter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BNKCounter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DdgKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DdtKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValidComm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrozenComm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string chainStore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DiscInRet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string State1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string State2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Indicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ShipType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DebPayAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShipToDef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Block { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MailBlock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ECVatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Deleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IBAN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FormCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Box1099 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BackOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PartDelivr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DunnLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DunnDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockDunn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCountr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CollecAuth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InstrucKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SinglePaym { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string ISRBillId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaymBlock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HouseBank { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string OwnerIdNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PyBlckDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HousBnkCry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HousBnkAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HousBnkBrn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProjectCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SysMatchNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string VatIdUnCmp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AgentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TolrncDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SelfInvoic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeferrTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LetterNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FromDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTLiable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrtfcateNO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ExpireDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NINum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AccCritria { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Equ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HldCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ConnBP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MltMthNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TypWTReprt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VATRegNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Industry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Business { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTTaxCat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsDomestic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsResident { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoCalBCG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OtrCtlAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AliasName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Building { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MailBuildi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoEPrsnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoEDiscnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoEOnClct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UnpaidBoE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ITWTCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DunTerm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChannlBP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DfTcnician { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Territory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BillToDef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpmClear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IntrntSite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LangCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? HousActKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Profession { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CDPNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DflBankKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BCACode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseShpdGd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RegNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VerifNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCtlKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HousCtlKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InsurOp347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MailAddrTy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MailStrNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxRndRule { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VendTID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ThreshOver { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SurOver { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VendorOcup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OpCode347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpmIntAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResidenNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PlngGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatIDNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Affiliate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MivzExpSts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HierchDdct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CertWHT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CertBKeep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WHShaamGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IndustryC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DatevAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DatevFirst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GTSRegNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GTSBankAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GTSBilAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HsBnkSwift { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HsBnkIBAN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflSwift { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoPost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IntrAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FeeAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CpnNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? NTSWebSite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflIBAN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EDocExpFrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxIdIdent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attachment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DiscRel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NoDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SCAdjust { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DflAgrmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GlblLocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SenderID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RcpntID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MainUsage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SefazCheck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string free312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string free313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateTill { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RelCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OKATO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OKTMO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KBKCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TypeOfOp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OwnerCode { get; set; }
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
        public int? Remark1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ConCerti { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TpCusPres { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RoleTypCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockComm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmplymntCt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExcptnlEvt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpnPrfFnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EdrsFromBP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EdrsToBP { get; set; }
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
        public string EDocGenTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string eStreet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string eStreetNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? eBuildnNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string eZipCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string eCityTown { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string eCountry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string eDistrict { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepFName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepSName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepCmpName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepFisCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepAddID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PECAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IPACodePA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriceMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EffecPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TxExMxVdTp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MerchantID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseBilAddr { get; set; }
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
        public string EnAddID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnDflAccnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnDflIBAN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnERD4In { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnERD4Out { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflCustomr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TspEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TspLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FCERelevnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FCEVldte { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PYSX { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_FName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_job_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_FPLB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_Prefix { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_Suffix { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_is_reseller { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_EndCustomerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_EndCustomerContact { get; set; }
    }
}