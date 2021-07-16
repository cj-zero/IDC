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
    public partial class VRW2 
    {
        public VRW2()
        {
          this.Selected= string.Empty;
          this.LineStatus= string.Empty;
          this.DebitAcc= string.Empty;
          this.DocDate= DateTime.Now;
          this.Ref1= string.Empty;
          this.Ref2= string.Empty;
          this.Ref3= string.Empty;
          this.Remarks= string.Empty;
          this.TrnsCode= string.Empty;
          this.ARDocNumAb= string.Empty;
          this.ARObjType= string.Empty;
          this.ARDocDate= DateTime.Now;
          this.CstmrCode= string.Empty;
          this.CstmrName= string.Empty;
          this.TpiDocDate= DateTime.Now;
          this.VendorCode= string.Empty;
          this.VendorName= string.Empty;
          this.ARDocMemo= string.Empty;
          this.TpiMemo= string.Empty;
          this.VatAcc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Selected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DebitAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NetAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? JETransID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrnsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? BPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARDocNumAb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ARAbsEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ARDocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstmrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstmrName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TpiDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TpiDocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VendorCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VendorName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARDocMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TpiMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrsAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenVatAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenNetAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenGrsAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RepstedVat { get; set; }
    }
}