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
    public partial class NNM4 
    {
        public NNM4()
        {
          this.SeriesName= string.Empty;
          this.NextNumber= string.Empty;
          this.LastNum= string.Empty;
          this.Prefix= string.Empty;
          this.Remark= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeriesName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NextNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LastNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Prefix { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ApprovYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ApprovNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remark { get; set; }
    }
}