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
    public partial class TPW3 
    {
        public TPW3()
        {
          this.PymMeth= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CrUtiliz { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CrUtilizFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CrUtilizSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PymMeth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PymAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PymAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PymAmntSC { get; set; }
    }
}