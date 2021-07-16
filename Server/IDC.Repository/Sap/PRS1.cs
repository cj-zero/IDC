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
    public partial class PRS1 
    {
        public PRS1()
        {
          this.LaytCode= string.Empty;
          this.Printer= string.Empty;
          this.Prtr1st= string.Empty;
          this.Use1stPrtr= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ObjectID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LaytCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? NumCopy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UsrQuery { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SubDocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Printer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Prtr1st { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Use1stPrtr { get; set; }
    }
}