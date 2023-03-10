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
    public partial class ITM1 
    {
        public ITM1()
        {
          this.Currency= string.Empty;
          this.Ovrwritten= string.Empty;
          this.ObjType= string.Empty;
          this.Currency1= string.Empty;
          this.Currency2= string.Empty;
          this.Ovrwrite1= string.Empty;
          this.Ovrwrite2= string.Empty;
          this.PriceType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ovrwritten { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Factor { get; set; }
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
        public decimal? AddPrice1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AddPrice2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ovrwrite1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ovrwrite2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BasePLNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UomEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriceType { get; set; }
    }
}