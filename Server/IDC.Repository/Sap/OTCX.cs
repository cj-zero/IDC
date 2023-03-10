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
    public partial class OTCX 
    {
        public OTCX()
        {
          this.UDFTable1= string.Empty;
          this.StrVal1= string.Empty;
          this.UDFTable2= string.Empty;
          this.StrVal2= string.Empty;
          this.UdfTable3= string.Empty;
          this.StrVal3= string.Empty;
          this.UdfTable4= string.Empty;
          this.StrVal4= string.Empty;
          this.UdfTable5= string.Empty;
          this.StrVal5= string.Empty;
          this.Descr= string.Empty;
          this.LnTaxCode= string.Empty;
          this.FrLnTax= string.Empty;
          this.FrHdrTax= string.Empty;
          this.UDFAlias1= string.Empty;
          this.UDFAlias2= string.Empty;
          this.UDFAlias3= string.Empty;
          this.UDFAlias4= string.Empty;
          this.UDFAlias5= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BusArea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Cond1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UDFTable1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumVal1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StrVal1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MnyVal1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Cond2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UDFTable2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumVal2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StrVal2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MnyVal2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Cond3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UdfTable3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumVal3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StrVal3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MnyVal3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Cond4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UdfTable4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumVal4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StrVal4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MnyVal4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Cond5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UdfTable5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumVal5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StrVal5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MnyVal5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LnTaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrLnTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrHdrTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UDFAlias1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UDFAlias2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UDFAlias3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UDFAlias4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UDFAlias5 { get; set; }
    }
}