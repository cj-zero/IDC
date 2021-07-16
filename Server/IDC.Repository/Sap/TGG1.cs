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
    public partial class TGG1 
    {
        public TGG1()
        {
          this.CardCode= string.Empty;
          this.CardName= string.Empty;
          this.GroupCode= string.Empty;
          this.Industry= string.Empty;
          this.validFor= string.Empty;
          this.CntctPrsn= string.Empty;
          this.Title= string.Empty;
          this.Position= string.Empty;
          this.E_Mail= string.Empty;
          this.Telephone= string.Empty;
          this.Cellolar= string.Empty;
          this.Fax= string.Empty;
          this.Address= string.Empty;
          this.Street= string.Empty;
          this.Block= string.Empty;
          this.City= string.Empty;
          this.ZipCode= string.Empty;
          this.County= string.Empty;
          this.State= string.Empty;
          this.Country= string.Empty;
          this.Building= string.Empty;
          this.FirstName= string.Empty;
          this.MiddleName= string.Empty;
          this.LastName= string.Empty;
          this.LicTradNum= string.Empty;
          this.AddrType= string.Empty;
          this.Address2= string.Empty;
          this.Address3= string.Empty;
          this.StreetNo= string.Empty;
          this.AddressID= string.Empty;
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
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Industry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string validFor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntctPrsn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string E_Mail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Telephone { get; set; }
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
        public string Address { get; set; }
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
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ZipCode { get; set; }
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
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Building { get; set; }
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
        public string LicTradNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrType { get; set; }
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
        public string StreetNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddressID { get; set; }
    }
}