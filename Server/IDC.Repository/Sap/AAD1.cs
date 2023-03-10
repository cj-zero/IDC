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
    public partial class AAD1 
    {
        public AAD1()
        {
          this.CurrPeriod= string.Empty;
          this.Street= string.Empty;
          this.StreetF= string.Empty;
          this.Block= string.Empty;
          this.BlockF= string.Empty;
          this.City= string.Empty;
          this.CityF= string.Empty;
          this.ZipCode= string.Empty;
          this.ZipCodeF= string.Empty;
          this.County= string.Empty;
          this.CountyF= string.Empty;
          this.State= string.Empty;
          this.Country= string.Empty;
          this.IntrntAdrs= string.Empty;
          this.AssType= string.Empty;
          this.CompnyType= string.Empty;
          this.NatureBiz= string.Empty;
          this.TaxIdNum4= string.Empty;
          this.TaxIdNum5= string.Empty;
          this.TaxIdNum6= string.Empty;
          this.AddrType= string.Empty;
          this.AddrTypeF= string.Empty;
          this.StreetNo= string.Empty;
          this.StreetNoF= string.Empty;
          this.Building= string.Empty;
          this.BuildingF= string.Empty;
          this.EccNo= string.Empty;
          this.CERegNo= string.Empty;
          this.CERange= string.Empty;
          this.CEDivision= string.Empty;
          this.CeComRate= string.Empty;
          this.MenuCode= string.Empty;
          this.Jurisd= string.Empty;
          this.CredCOrig= string.Empty;
          this.IPIPeriod= string.Empty;
          this.DspIBPDoc= string.Empty;
          this.DspIITMDoc= string.Empty;
          this.IPITaxCon= string.Empty;
          this.ISVATRegNo= string.Empty;
          this.ISVATRegEx= string.Empty;
          this.ISObligLvl= string.Empty;
          this.ISTaxState= string.Empty;
          this.ISComDecID= string.Empty;
          this.OKDPNum= string.Empty;
          this.ISValidKey= string.Empty;
          this.ISDnsce= string.Empty;
          this.ISDfltPath= string.Empty;
          this.ISSimpProc= string.Empty;
          this.ISForceCmp= string.Empty;
          this.ISCstRecSt= string.Empty;
          this.ISExlDocQt= string.Empty;
          this.ISExlDocAm= string.Empty;
          this.ISDspNMass= string.Empty;
          this.ImInfSup= string.Empty;
          this.Free2= string.Empty;
          this.CommerReg= string.Empty;
          this.DateOfInc= DateTime.Now;
          this.SPEDProf= string.Empty;
          this.Opt4ICMS= string.Empty;
          this.ISInstIntr= string.Empty;
          this.GlblLocNum= string.Empty;
          this.PTLedgeGen= string.Empty;
          this.BZStRegID= string.Empty;
          this.BZStSendID= string.Empty;
          this.PostInVat= string.Empty;
          this.EnbEATrns= string.Empty;
          this.EnbEAInv= string.Empty;
          this.AuthUser= string.Empty;
          this.AuthPwd= string.Empty;
          this.UrlGoods= string.Empty;
          this.UrlInvType= string.Empty;
          this.ElDigiCert= string.Empty;
          this.TaxRptFrm= DateTime.Now;
          this.Suframa= string.Empty;
          this.EnbInItIQI= string.Empty;
          this.EnbInItINC= string.Empty;
          this.ExtRevAct= string.Empty;
          this.IsStartup= string.Empty;
          this.IsCUITMndt= string.Empty;
          this.LnMlBrnch= string.Empty;
          this.DfBrnchPh= string.Empty;
          this.AplShipPch= string.Empty;
          this.AsnBrnchBP= string.Empty;
          this.ApyPRinAT= string.Empty;
          this.ApyDRinAT= string.Empty;
          this.EnMlBrkInv= string.Empty;
          this.PEFilePath= string.Empty;
          this.EnableGDPR= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CurrPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Street { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Block { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CityF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ZipCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ZipCodeF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string County { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CountyF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IntrntAdrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AssType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompnyType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NatureBiz { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxIdNum4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxIdNum5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxIdNum6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrTypeF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetNoF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Building { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BuildingF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EccNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CERegNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CERange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CEDivision { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CeComRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MenuCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Jurisd { get; set; }
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
        public int? STDCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? STDCodeF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CompNature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EconActT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CredCOrig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IPIPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CoopAssocT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DspIBPDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DspIITMDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ProfTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CompQualif { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DeclType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IPITaxCon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISVATRegNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISVATRegEx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISObligLvl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISTaxState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISComDecID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OKDPNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISValidKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISDnsce { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISDfltPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISSimpProc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISForceCmp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISCstRecSt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISDfltInct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISDfCPEx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISDfCPIm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISDfNTEx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISDfNTIm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISDfPortEx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISDfPortIm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISDfSPEx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISDfSPIm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISDfCSTEx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISDfCSTIm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISDfTMEx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISDfTMIm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ISDeclDept { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISExlDocQt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ISDocQtLm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISExlDocAm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ISDocAmLm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISDspNMass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ImInfSup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Free2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CommerReg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateOfInc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SPEDProf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EnvTypeNFe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Opt4ICMS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISInstIntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GlblLocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PTLedgeGen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BZStRegID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BZStSendID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PostInVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnbEATrns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnbEAInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AuthUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AuthPwd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UrlGoods { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UrlInvType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ElGoodsFmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ElInvFmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ElDigiCert { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxRptFrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Suframa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnbInItIQI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnbInItINC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtRevAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsStartup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsCUITMndt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LnMlBrnch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfBrnchPh { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AplShipPch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AsnBrnchBP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApyPRinAT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApyDRinAT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnMlBrkInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PEFilePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnableGDPR { get; set; }
    }
}