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
    public partial class OCCD 
    {
        public OCCD()
        {
          this.Date= DateTime.Now;
          this.CustBroker= string.Empty;
          this.DocNum= string.Empty;
          this.DocDate= DateTime.Now;
          this.SupNum= string.Empty;
          this.SupDate= DateTime.Now;
          this.CustTerm= string.Empty;
          this.PayKey= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CustBroker { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SupNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SupDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CustTerm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayKey { get; set; }
    }
}