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
    public partial class CFH1 
    {
        public CFH1()
        {
          this.DispItem= string.Empty;
          this.LineNum= string.Empty;
          this.IndentChar= string.Empty;
          this.Formula= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DispItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Levels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IndentChar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Formula { get; set; }
    }
}