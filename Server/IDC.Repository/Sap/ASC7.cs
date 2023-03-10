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
    public partial class ASC7 
    {
        public ASC7()
        {
          this.TaxId0= string.Empty;
          this.TaxId1= string.Empty;
          this.TaxId2= string.Empty;
          this.TaxId3= string.Empty;
          this.TaxId4= string.Empty;
          this.TaxId5= string.Empty;
          this.TaxId6= string.Empty;
          this.TaxId7= string.Empty;
          this.TaxId8= string.Empty;
          this.TaxId9= string.Empty;
          this.State= string.Empty;
          this.County= string.Empty;
          this.Incoterms= string.Empty;
          this.Vehicle= string.Empty;
          this.VidState= string.Empty;
          this.NfRef= string.Empty;
          this.Carrier= string.Empty;
          this.PackDesc= string.Empty;
          this.Brand= string.Empty;
          this.ObjectType= string.Empty;
          this.TaxId10= string.Empty;
          this.TransCat= string.Empty;
          this.FormNo= string.Empty;
          this.TaxId11= string.Empty;
          this.StreetS= string.Empty;
          this.BlockS= string.Empty;
          this.BuildingS= string.Empty;
          this.CityS= string.Empty;
          this.ZipCodeS= string.Empty;
          this.CountyS= string.Empty;
          this.StateS= string.Empty;
          this.CountryS= string.Empty;
          this.AddrTypeS= string.Empty;
          this.StreetNoS= string.Empty;
          this.StreetB= string.Empty;
          this.BlockB= string.Empty;
          this.BuildingB= string.Empty;
          this.CityB= string.Empty;
          this.ZipCodeB= string.Empty;
          this.CountyB= string.Empty;
          this.StateB= string.Empty;
          this.CountryB= string.Empty;
          this.AddrTypeB= string.Empty;
          this.StreetNoB= string.Empty;
          this.ImpORExp= string.Empty;
          this.Vat= string.Empty;
          this.AltCrdNamB= string.Empty;
          this.AltTaxIdB= string.Empty;
          this.Address2S= string.Empty;
          this.Address3S= string.Empty;
          this.Address2B= string.Empty;
          this.Address3B= string.Empty;
          this.GlbLocNumS= string.Empty;
          this.GlbLocNumB= string.Empty;
          this.CollectDT= string.Empty;
          this.TransprtDT= DateTime.Now;
          this.TransprtRS= string.Empty;
          this.TaxId12= string.Empty;
          this.TaxId13= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string County { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Incoterms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Vehicle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VidState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NfRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Carrier { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? QoP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PackDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Brand { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NoSU { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NetWeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrsWeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransCat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FormNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BuildingS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CityS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ZipCodeS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CountyS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StateS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CountryS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrTypeS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetNoS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BuildingB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CityB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ZipCodeB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CountyB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StateB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CountryB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrTypeB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetNoB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ImpORExp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Vat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AltCrdNamB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string AltTaxIdB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address2S { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address3S { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address2B { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address3B { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MainUsage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GlbLocNumS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GlbLocNumB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CollectDT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TransprtDT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransprtRS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxId13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}