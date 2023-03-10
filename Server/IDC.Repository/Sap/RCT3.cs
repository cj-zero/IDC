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
    public partial class RCT3 
    {
        public RCT3()
        {
          this.CreditAcct= string.Empty;
          this.CrCardNum= string.Empty;
          this.CardValid= DateTime.Now;
          this.VoucherNum= string.Empty;
          this.OwnerIdNum= string.Empty;
          this.OwnerPhone= string.Empty;
          this.FirstDue= DateTime.Now;
          this.CreditCur= string.Empty;
          this.ConfNum= string.Empty;
          this.CreditType= string.Empty;
          this.PlCrdStat= string.Empty;
          this.MagnetStr= string.Empty;
          this.SpiltCred= string.Empty;
          this.ObjType= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreditCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreditAcct { get; set; }
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
        public string VoucherNum { get; set; }
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
        public string OwnerPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CrTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? NumOfPmnts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FirstDue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FirstSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AddPmntSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CreditSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreditCur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CreditRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ConfNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreditType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CredPmnts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PlCrdStat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MagnetStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpiltCred { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ConsolNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}