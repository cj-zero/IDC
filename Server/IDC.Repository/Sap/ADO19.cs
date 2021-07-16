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
    public partial class ADO19 
    {
        public ADO19()
        {
          this.ItemCode= string.Empty;
          this.WhsCode= string.Empty;
          this.AllowNeg= string.Empty;
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
        public int? SubLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SnBType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SnBMDAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BinAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AllowNeg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BinActTyp { get; set; }
    }
}