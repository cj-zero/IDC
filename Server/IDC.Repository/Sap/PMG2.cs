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
    public partial class PMG2 
    {
        public PMG2()
        {
          this.REMARKS= string.Empty;
          this.CLOSED= string.Empty;
          this.SOLUTION= string.Empty;
          this.DATE= DateTime.Now;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AREA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PRIORITY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string REMARKS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CLOSED { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SOLUTIONID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SOLUTION { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RESPNSIBLE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ENTERED { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DATE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EFFORT { get; set; }
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