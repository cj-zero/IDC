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
    public partial class EBL1 
    {
        public EBL1()
        {
          this.Selected= string.Empty;
          this.Mandatory= string.Empty;
          this.DocType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ReportType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Selected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Mandatory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] DocContent { get; set; }
    }
}