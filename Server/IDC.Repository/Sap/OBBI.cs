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
    public partial class OBBI 
    {
        public OBBI()
        {
          this.TableCode= string.Empty;
          this.BrandCode= 0;
          this.GroupCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TableCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int BrandCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
    }
}