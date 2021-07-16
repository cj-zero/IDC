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
    public partial class ADM2 
    {
        public ADM2()
        {
          this.TaxAuCod= string.Empty;
          this.KeyEcoAct= string.Empty;
          this.TaxPayType= string.Empty;
          this.TaxLegForm= string.Empty;
          this.RegName= string.Empty;
          this.RegNameExt= string.Empty;
          this.SoleFName= string.Empty;
          this.SoleSName= string.Empty;
          this.SoleTitle= string.Empty;
          this.CityTown= string.Empty;
          this.ZipCode= string.Empty;
          this.Telephone= string.Empty;
          this.Street= string.Empty;
          this.StreetNum= string.Empty;
          this.Email= string.Empty;
          this.State= string.Empty;
          this.RepType= string.Empty;
          this.RepCode= string.Empty;
          this.RepFName= string.Empty;
          this.RepSName= string.Empty;
          this.CompName= string.Empty;
          this.BirthDate= DateTime.Now;
          this.TaxACNum= string.Empty;
          this.LegEntitID= string.Empty;
          this.AuthFName= string.Empty;
          this.AuthLName= string.Empty;
          this.AuthRelat= string.Empty;
          this.AuthType= string.Empty;
          this.TaxPayAttr= string.Empty;
          this.Classifier= string.Empty;
          this.DeprMethod= string.Empty;
          this.SubmitPlac= string.Empty;
          this.BgtClass= string.Empty;
          this.SubjOfRuF= string.Empty;
          this.AuthFathrN= string.Empty;
          this.BgtCleVAT= string.Empty;
          this.RepTitle= string.Empty;
          this.TaxRegime= string.Empty;
          this.SoleBDate= DateTime.Now;
          this.SoleGender= string.Empty;
          this.SoleCity= string.Empty;
          this.SoleDistri= string.Empty;
          this.RepFisCode= string.Empty;
          this.RepPosCode= string.Empty;
          this.RepGender= string.Empty;
          this.RepCity= string.Empty;
          this.RepDistri= string.Empty;
          this.RepDate1= DateTime.Now;
          this.RepDate2= DateTime.Now;
          this.RepPhone= string.Empty;
          this.RepEmail= string.Empty;
          this.Country= string.Empty;
          this.District= string.Empty;
          this.RegDistri= string.Empty;
          this.RegSHolder= string.Empty;
          this.RegLiquida= string.Empty;
          this.RepAddID= string.Empty;
          this.ActCode= string.Empty;
          this.PosCode347= string.Empty;
          this.FiscalCode= string.Empty;
          this.DataBoxID= string.Empty;
          this.RepCEOName= string.Empty;
          this.RepCEOFisC= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxAuCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyEcoAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxPayType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxLegForm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RegName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RegNameExt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SoleFName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SoleSName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SoleTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CityTown { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ZipCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Telephone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Street { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BuildinNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepCode { get; set; }
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
        public string CompName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BirthDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxACNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LegEntitID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AuthFName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AuthLName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AuthRelat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AuthType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxPayAttr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Classifier { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeprMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubmitPlac { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BgtClass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubjOfRuF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AuthFathrN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BgtCleVAT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxRegime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SoleBDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SoleGender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SoleCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SoleDistri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepFisCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepPosCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepGender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepDistri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RepDate1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RepDate2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string District { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RegDistri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RegSCAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RegSHolder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RegLiquida { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepAddID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PosCode347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FiscalCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataBoxID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SmValLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepCEOName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepCEOFisC { get; set; }
    }
}