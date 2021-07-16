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
    public partial class OALC 
    {
        public OALC()
        {
          this.AlcName= string.Empty;
          this.OhType= string.Empty;
          this.AcctCode= string.Empty;
          this.DataSource= string.Empty;
          this.LaCAllcAcc= string.Empty;
          this.CostCateg= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AlcName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OhType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctCode { get; set; }
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
        public string LaCAllcAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostCateg { get; set; }
    }
}