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
    public partial class OPTF 
    {
        public OPTF()
        {
          this.PtfId= string.Empty;
          this.PtfCode= string.Empty;
          this.PtfNum= string.Empty;
          this.PtfDespt= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string PtfId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PtfCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PtfNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PtfDespt { get; set; }
    }
}