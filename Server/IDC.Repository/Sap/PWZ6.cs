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
    public partial class PWZ6 
    {
        public PWZ6()
        {
          this.SelFldID= string.Empty;
          this.FromString= string.Empty;
          this.FromDate= DateTime.Now;
          this.FromMemo= string.Empty;
          this.ToString= string.Empty;
          this.ToDate= DateTime.Now;
          this.ToMemo= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SelFldID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromString { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FromNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FromMoney { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FromDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToString { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ToNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ToMoney { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToMemo { get; set; }
    }
}