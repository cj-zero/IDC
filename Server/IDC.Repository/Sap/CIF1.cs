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
    public partial class CIF1 
    {
        public CIF1()
        {
          this.IsMandImp= string.Empty;
          this.IsMandExp= string.Empty;
          this.IsReqAllIm= string.Empty;
          this.IsReqAllEx= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsMandImp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsMandExp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsReqAllIm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsReqAllEx { get; set; }
    }
}