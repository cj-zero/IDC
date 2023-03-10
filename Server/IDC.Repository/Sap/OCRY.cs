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
    public partial class OCRY 
    {
        public OCRY()
        {
          this.Name= string.Empty;
          this.IsEC= string.Empty;
          this.ReportCode= string.Empty;
          this.ValDomAcct= string.Empty;
          this.ValIban= string.Empty;
          this.IsBlackLst= string.Empty;
          this.UICCode= string.Empty;
          this.CntCodNum= string.Empty;
          this.Siscomex= string.Empty;
          this.IsIntraS= string.Empty;
          this.EAEU= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? AddrFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsEC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReportCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public short? TaxIdDigts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BnkCodDgts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BnkBchDgts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BnkActDgts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BnkCtKDgts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValDomAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValIban { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsBlackLst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UICCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntCodNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Siscomex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsIntraS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EAEU { get; set; }
    }
}