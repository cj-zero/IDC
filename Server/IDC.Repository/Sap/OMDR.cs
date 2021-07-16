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
    public partial class OMDR 
    {
        public OMDR()
        {
          this.OcrName= string.Empty;
          this.Direct= string.Empty;
          this.Locked= string.Empty;
          this.DataSource= string.Empty;
          this.Active= string.Empty;
          this.updateDate= DateTime.Now;
          this.IsFixedAmt= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OcrTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Direct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
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
        public short? DimCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AbsEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? logInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? updateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsFixedAmt { get; set; }
    }
}