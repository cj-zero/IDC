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
    public partial class ODSC 
    {
        public ODSC()
        {
          this.BankCode= string.Empty;
          this.BankName= string.Empty;
          this.DfltAcct= string.Empty;
          this.DfltBranch= string.Empty;
          this.Locked= string.Empty;
          this.DataSource= string.Empty;
          this.SwiftNum= string.Empty;
          this.IBAN= string.Empty;
          this.CountryCod= string.Empty;
          this.PostOffice= string.Empty;
          this.AliasName= string.Empty;
          this.BsPstDate= string.Empty;
          this.BsValDate= string.Empty;
          this.BsDocDate= string.Empty;
          this.TaxIdNum= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltBranch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NextChckNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SwiftNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IBAN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CountryCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PostOffice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AliasName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DfltActKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NextNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BsPstDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BsValDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BnkOpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BsDocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TaxIdNum { get; set; }
    }
}