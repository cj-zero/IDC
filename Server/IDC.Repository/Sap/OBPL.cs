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
    public partial class OBPL 
    {
        public OBPL()
        {
          this.BPLName= string.Empty;
          this.BPLFrName= string.Empty;
          this.VATRegNum= string.Empty;
          this.RepName= string.Empty;
          this.Industry= string.Empty;
          this.Business= string.Empty;
          this.Address= string.Empty;
          this.AddressFr= string.Empty;
          this.MainBPL= string.Empty;
          this.TxOffcNo= string.Empty;
          this.Disabled= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.DflCust= string.Empty;
          this.DflVendor= string.Empty;
          this.DflWhs= string.Empty;
          this.DflTaxCode= string.Empty;
          this.RevOffice= string.Empty;
          this.TaxIdNum= string.Empty;
          this.TaxIdNum2= string.Empty;
          this.TaxIdNum3= string.Empty;
          this.AddtnlId= string.Empty;
          this.CredCOrig= string.Empty;
          this.IPIPeriod= string.Empty;
          this.PrefState= string.Empty;
          this.AddrType= string.Empty;
          this.Street= string.Empty;
          this.StreetNo= string.Empty;
          this.Building= string.Empty;
          this.ZipCode= string.Empty;
          this.Block= string.Empty;
          this.City= string.Empty;
          this.State= string.Empty;
          this.County= string.Empty;
          this.Country= string.Empty;
          this.PmtClrAct= string.Empty;
          this.CommerReg= string.Empty;
          this.DateOfInc= DateTime.Now;
          this.SPEDProf= string.Empty;
          this.Opt4ICMS= string.Empty;
          this.AliasName= string.Empty;
          this.GlblLocNum= string.Empty;
          this.TaxRptFrm= DateTime.Now;
          this.Suframa= string.Empty;
          this.DfltResWhs= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPLName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPLFrName { get; set; }
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
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddressFr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MainBPL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TxOffcNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Disabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
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
        public string DflCust { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflVendor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflWhs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflTaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevOffice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxIdNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxIdNum2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxIdNum3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string AddtnlId { get; set; }
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
        public string PrefState { get; set; }
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
        public string AddrType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Street { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Building { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ZipCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Block { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string City { get; set; }
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
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PmtClrAct { get; set; }
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
        public string AliasName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GlblLocNum { get; set; }
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
        public string DfltResWhs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? SnapshotId { get; set; }
    }
}