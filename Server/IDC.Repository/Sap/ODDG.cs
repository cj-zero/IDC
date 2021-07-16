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
    public partial class ODDG 
    {
        public ODDG()
        {
          this.DdgCode= string.Empty;
          this.DdgName= string.Empty;
          this.DataSource= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DdgCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DdgName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DdctPrcnt { get; set; }
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
    }
}