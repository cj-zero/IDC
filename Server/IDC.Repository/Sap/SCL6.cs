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
    public partial class SCL6 
    {
        public SCL6()
        {
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.AddressId= string.Empty;
          this.Address= string.Empty;
          this.Reminder= string.Empty;
          this.DisplInCal= string.Empty;
          this.Unsched= string.Empty;
          this.DurType= string.Empty;
          this.RemType= string.Empty;
          this.RemDate= DateTime.Now;
          this.RemSent= string.Empty;
          this.Street= string.Empty;
          this.City= string.Empty;
          this.Room= string.Empty;
          this.State= string.Empty;
          this.Country= string.Empty;
          this.Address2= string.Empty;
          this.Address3= string.Empty;
          this.AddrType= string.Empty;
          this.StreetNo= string.Empty;
          this.ZipCode= string.Empty;
          this.Block= string.Empty;
          this.County= string.Empty;
          this.TaxOffice= string.Empty;
          this.GlblLocNum= string.Empty;
          this.ActDurType= string.Empty;
          this.Close= string.Empty;
          this.Remark= string.Empty;
          this.AddrTypeBS= string.Empty;
          this.SignName= string.Empty;
          this.SaleOrders= string.Empty;
          this.ChkInDate= DateTime.Now;
          this.ChkInLoc= string.Empty;
          this.ChkLontitu= string.Empty;
          this.ChkLatitu= string.Empty;
          this.ChkOutDate= DateTime.Now;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Technician { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? HandledBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Duration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string AddressId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Reminder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RemQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DisplInCal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Unsched { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DurType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RemType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RemDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RemSent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RemTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Street { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Room { get; set; }
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
        public string Address2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address3 { get; set; }
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
        public string County { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxOffice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GlblLocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ActualDur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActDurType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Close { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrTypeBS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SignName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SaleOrders { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ChkInDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ChkInTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChkInLoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChkLontitu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChkLatitu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ChkOutDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ChkOutTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] SignData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}