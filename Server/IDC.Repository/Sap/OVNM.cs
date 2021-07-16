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
    public partial class OVNM 
    {
        public OVNM()
        {
          this.NumName= string.Empty;
          this.First= string.Empty;
          this.Next= string.Empty;
          this.Last= string.Empty;
          this.YrDepend= string.Empty;
          this.DefaultNum= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NumName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string First { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Next { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Last { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string YrDepend { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DefaultNum { get; set; }
    }
}