using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDC.Repository.Entities.NsapBone
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("NsapBoneDbContext","NsapBoneReadDbContext")]
    public partial class sale_ordr_plugin 
    {
        /// <summary>
        /// 
        /// </summary>
        public sale_ordr_plugin()
        {
          this.InvoiceName= string.Empty;
          this.InvoiceTaxSignNo= string.Empty;
          this.InvoiceReceivePhone= string.Empty;
          this.InvoiceReceiveEmail= string.Empty;
          this.InvoiceReceiveAddress= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? sbo_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayTransactionID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InvoiceTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvoiceName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvoiceTaxSignNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvoiceReceivePhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvoiceReceiveEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvoiceReceiveAddress { get; set; }
    }
}