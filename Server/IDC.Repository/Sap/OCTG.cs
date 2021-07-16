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
    public partial class OCTG 
    {
        public OCTG()
        {
          this.PymntGroup= string.Empty;
          this.PayDuMonth= string.Empty;
          this.Payments= string.Empty;
          this.DataSource= string.Empty;
          this.OpenRcpt= string.Empty;
          this.DiscCode= string.Empty;
          this.DunningCod= string.Empty;
          this.BslineDate= string.Empty;
          this.VATFirst= string.Empty;
          this.CrdMthd= string.Empty;
          this.CshRelev= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymntGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayDuMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ExtraMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ExtraDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PaymntsNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CredLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VolumDscnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LatePyChrg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ObligLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ListNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Payments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? NumOfPmnts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Payment1 { get; set; }
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
        public string OpenRcpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DiscCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DunningCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BslineDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? InstNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TolDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VATFirst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdMthd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CshRelev { get; set; }
    }
}