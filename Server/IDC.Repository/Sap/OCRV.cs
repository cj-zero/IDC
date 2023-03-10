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
    public partial class OCRV 
    {
        public OCRV()
        {
          this.CrdCardNum= string.Empty;
          this.CardValid= DateTime.Now;
          this.VoucherNum= string.Empty;
          this.OwnerIdNum= string.Empty;
          this.OwnerPhone= string.Empty;
          this.PayDate= DateTime.Now;
          this.CreditCurr= string.Empty;
          this.Deposited= string.Empty;
          this.AcctCode= string.Empty;
          this.VouchAcct= string.Empty;
          this.CreditAcct= string.Empty;
          this.CardCode= string.Empty;
          this.Canceled= string.Empty;
          this.Storno= string.Empty;
          this.Transfered= string.Empty;
          this.DataSource= string.Empty;
          this.TransRef= string.Empty;
          this.CardName= string.Empty;
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
        public string CrdCardNum { get; set; }
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
        public System.DateTime? PayDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PayAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreditCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CreditRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Deposited { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DepNum2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DepNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VouchAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreditAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
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
        public string Canceled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Storno { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
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
        public string TransRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
    }
}