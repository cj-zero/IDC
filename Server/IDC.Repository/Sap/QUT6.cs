﻿using System;
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
    public partial class QUT6 
    {
        public QUT6()
        {
          this.ObjType= string.Empty;
          this.DueDate= DateTime.Now;
          this.Status= string.Empty;
          this.DunWizBlck= string.Empty;
          this.DunDate= DateTime.Now;
          this.reserved= string.Empty;
          this.LvlUpdDate= DateTime.Now;
          this.Ordered= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
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
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DunnLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InsTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InsTotalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InsTotalSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPaid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPaidFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPaidSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalExpns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalExpFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalExpSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpAppl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpApplFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpApplSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTApplied { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTAppliedF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTAppliedS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalBlck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalBlckF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalBlckS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VATBlck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VATBlckFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VATBlckSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpnsBlck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpnsBlckF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpnsBlckS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTBlocked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTBlockedF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTBlockedS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InstPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DunWizBlck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DunDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Paid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidFrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string reserved { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExpFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExpSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExpAp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExApF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExApS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExBlo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExBlF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxOnExBlS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LvlUpdDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ordered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidDpm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidDpmFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidDpmSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}