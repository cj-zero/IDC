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
    public partial class OGPC 
    {
        public OGPC()
        {
          this.Code= string.Empty;
          this.Descr= string.Empty;
          this.StateTax= string.Empty;
          this.Prdcity= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StateTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Prdcity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SPEDCtgory { get; set; }
    }
}