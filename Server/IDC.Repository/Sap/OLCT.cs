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
    public partial class OLCT 
    {
        public OLCT()
        {
          this.Location= string.Empty;
          this.PanCirNo= string.Empty;
          this.PanWardNo= string.Empty;
          this.PanOfficer= string.Empty;
          this.TanCirNo= string.Empty;
          this.TanWardNo= string.Empty;
          this.TanOfficer= string.Empty;
          this.LstVatNo= string.Empty;
          this.CstNo= string.Empty;
          this.ExemptNo= string.Empty;
          this.TanNo= string.Empty;
          this.ServTaxNo= string.Empty;
          this.AsseType= string.Empty;
          this.CompType= string.Empty;
          this.NatOfBiz= string.Empty;
          this.TinNo= string.Empty;
          this.PanNo= string.Empty;
          this.RegType= string.Empty;
          this.EccNo= string.Empty;
          this.CeRegNo= string.Empty;
          this.CeRange= string.Empty;
          this.CeDivision= string.Empty;
          this.CeComRate= string.Empty;
          this.ManuCode= string.Empty;
          this.Jurisd= string.Empty;
          this.Street= string.Empty;
          this.Block= string.Empty;
          this.ZipCode= string.Empty;
          this.City= string.Empty;
          this.County= string.Empty;
          this.Country= string.Empty;
          this.State= string.Empty;
          this.Building= string.Empty;
          this.SSIExmpt= string.Empty;
          this.SSIExmptSt= string.Empty;
          this.CitAddress= string.Empty;
          this.CitCity= string.Empty;
          this.CitPinCode= string.Empty;
          this.OnHoldAct= string.Empty;
          this.GSTRegnNo= string.Empty;
          this.GSTRelevt= string.Empty;
          this.GSTTDS= string.Empty;
          this.GSTISD= string.Empty;
          this.VendorCode= string.Empty;
          this.CstmerCode= string.Empty;
          this.DropShip= string.Empty;
          this.IngClrAc= string.Empty;
          this.IntBrClrAc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PanCirNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PanWardNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PanOfficer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TanCirNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TanWardNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TanOfficer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LstVatNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExemptNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TanNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ServTaxNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AsseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NatOfBiz { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TinNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PanNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RegType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EccNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CeRegNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CeRange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CeDivision { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CeComRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManuCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Jurisd { get; set; }
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
        public string Building { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SSIExmpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SSIExmptSt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CitAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CitCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CitPinCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OnHoldAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GSTRegnNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GSTRelevt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GSTTDS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GSTISD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? GSTType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VendorCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstmerCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DropShip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IngClrAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IntBrClrAc { get; set; }
    }
}