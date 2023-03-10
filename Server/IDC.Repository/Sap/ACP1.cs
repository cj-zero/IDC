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
    public partial class ACP1 
    {
        public ACP1()
        {
          this.BpCode= string.Empty;
          this.BpName= string.Empty;
          this.GroupName= string.Empty;
          this.Industry= string.Empty;
          this.Status= string.Empty;
          this.CntCode= string.Empty;
          this.CntTitle= string.Empty;
          this.CntPstn= string.Empty;
          this.CntEmail= string.Empty;
          this.CntTel= string.Empty;
          this.CntMobile= string.Empty;
          this.CntFax= string.Empty;
          this.CntAddr= string.Empty;
          this.Response= string.Empty;
          this.Street= string.Empty;
          this.Block= string.Empty;
          this.City= string.Empty;
          this.ZipCode= string.Empty;
          this.County= string.Empty;
          this.State= string.Empty;
          this.Country= string.Empty;
          this.Building= string.Empty;
          this.CActivity= string.Empty;
          this.DocType= string.Empty;
          this.ShowBPDoc= string.Empty;
          this.AssignTo= string.Empty;
          this.FirstName= string.Empty;
          this.MiddleName= string.Empty;
          this.LastName= string.Empty;
          this.LicTradNum= string.Empty;
          this.AddrType= string.Empty;
          this.Address2= string.Empty;
          this.Address3= string.Empty;
          this.StreetNo= string.Empty;
          this.AddressID= string.Empty;
          this.RspType= string.Empty;
          this.DPPStatus= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Industry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntPstn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntTel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntMobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntFax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Response { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? OpprId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VisOrder { get; set; }
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
        public string CActivity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowBPDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AssignTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AssignName { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RspType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPPStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}