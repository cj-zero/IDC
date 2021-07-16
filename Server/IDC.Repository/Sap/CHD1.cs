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
    public partial class CHD1 
    {
        public CHD1()
        {
          this.LineDitail= string.Empty;
          this.LineCurr= string.Empty;
          this.LineAcct= string.Empty;
          this.Line_A_C= string.Empty;
          this.Code= string.Empty;
          this.CredAcct= string.Empty;
          this.ObjType= string.Empty;
          this.UpdateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineDitail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineMoney { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Line_A_C { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CredAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPercent { get; set; }
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
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineMnyLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineMnySC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineMnyFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotLineLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotLineSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotLineFC { get; set; }
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
    }
}