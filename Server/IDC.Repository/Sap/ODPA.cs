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
    public partial class ODPA 
    {
        public ODPA()
        {
          this.Descr= string.Empty;
          this.DirectDpr= string.Empty;
          this.RetMeth= string.Empty;
          this.AreaType= string.Empty;
          this.DrvdArea= string.Empty;
          this.DataSource= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.MainArea= string.Empty;
          this.CreditCtrl= string.Empty;
          this.DirRevPost= string.Empty;
          this.BpTaxCorr= string.Empty;
          this.ItmTaxCorr= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DirectDpr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RetMeth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AreaType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DrvdArea { get; set; }
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
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MainArea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreditCtrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TaxType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DirRevPost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? SnapshotId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BpTaxCorr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmTaxCorr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UsgTaxCorr { get; set; }
    }
}