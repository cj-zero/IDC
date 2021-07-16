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
    public partial class HEM3 
    {
        public HEM3()
        {
          this.date= DateTime.Now;
          this.reviewDesc= string.Empty;
          this.grade= string.Empty;
          this.remarks= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string reviewDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? manager { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string grade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}