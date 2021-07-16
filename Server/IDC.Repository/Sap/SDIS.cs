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
    public partial class SDIS 
    {
        public SDIS()
        {
          this.ItemString= string.Empty;
          this.IsBold= string.Empty;
          this.IsItalic= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemString { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsBold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsItalic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
    }
}