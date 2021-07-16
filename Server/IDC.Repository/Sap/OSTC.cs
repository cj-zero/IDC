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
    public partial class OSTC 
    {
        public OSTC()
        {
          this.Name= string.Empty;
          this.Freight= string.Empty;
          this.ValidForAR= string.Empty;
          this.ValidForAP= string.Empty;
          this.Lock= string.Empty;
          this.TaxIcms= string.Empty;
          this.IsItmLevel= string.Empty;
          this.CfopIn= string.Empty;
          this.CfopOut= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.FADebit= string.Empty;
          this.IsSystem= string.Empty;
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
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Freight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValidForAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValidForAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TfcId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Lock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxIcms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsItmLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CfopIn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CfopOut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
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
        public string FADebit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsSystem { get; set; }
    }
}