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
    public partial class WLS5 
    {
        public WLS5()
        {
          this.WFInstID= string.Empty;
          this.SrcFld= string.Empty;
          this.TgtFld= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WFInstID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InputID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcFld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TgtFld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogIns { get; set; }
    }
}