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
    public partial class TRN1 
    {
        public TRN1()
        {
          this.ItemCode= string.Empty;
          this.ItemType= string.Empty;
          this.SlimType= string.Empty;
          this.SourceText= string.Empty;
          this.Memo= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SlimType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MaxLength { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SourceText { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Memo { get; set; }
    }
}