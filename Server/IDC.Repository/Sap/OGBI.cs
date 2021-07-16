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
    public partial class OGBI 
    {
        public OGBI()
        {
          this.RepNo= string.Empty;
          this.RepCompany= string.Empty;
          this.RepPeriod= string.Empty;
          this.Currency= string.Empty;
          this.CreateDate= string.Empty;
          this.RepEntity= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepCompany { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RepType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepEntity { get; set; }
    }
}