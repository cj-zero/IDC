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
    public partial class AIT8 
    {
        public AIT8()
        {
          this.SpDpKey1= string.Empty;
          this.SpDpKey2= string.Empty;
          this.SpDpKey3= string.Empty;
          this.ObjType= string.Empty;
          this.IsMaSalVal= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? APC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? APCHist { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrDpAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UnDpAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpDpKey1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SpDpAcc1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpDpKey2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SpDpAcc2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpDpKey3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SpDpAcc3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SalvageVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrDpAcc1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WriteUpAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsMaSalVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AppreAcc { get; set; }
    }
}