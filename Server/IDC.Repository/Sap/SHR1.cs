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
    public partial class SHR1 
    {
        public SHR1()
        {
          this.LineNum= string.Empty;
          this.ItemName= string.Empty;
          this.IndentChar= string.Empty;
          this.Formula= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public short? CatId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IndentChar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Formula { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CurAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PreAmount { get; set; }
    }
}