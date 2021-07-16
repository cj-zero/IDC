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
    public partial class PKL2 
    {
        public PKL2()
        {
          this.ItemCode= string.Empty;
          this.AllowNeg= string.Empty;
          this.ObjType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ManagedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SnBEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BinAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AllowNeg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RelQtty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PickQtty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
    }
}