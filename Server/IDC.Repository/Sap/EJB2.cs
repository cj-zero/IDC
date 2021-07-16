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
    public partial class EJB2 
    {
        public EJB2()
        {
          this.Selected= string.Empty;
          this.Mandatory= string.Empty;
          this.Type= string.Empty;
          this.FilePath= string.Empty;
        }

        
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
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RptSec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FilePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] FileStorag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VisOrder { get; set; }
    }
}