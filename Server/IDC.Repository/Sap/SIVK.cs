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
    public partial class SIVK 
    {
        public SIVK()
        {
          this.TransSeq= 0;
          this.LayerID= 0;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int TransSeq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int LayerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RootID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Instance { get; set; }
    }
}