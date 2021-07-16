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
    public partial class TCD2 
    {
        public TCD2()
        {
          this.Tcd1Id= 0;
          this.DispOrder= 0;
          this.KeyFld_1_V= string.Empty;
          this.KeyFld_2_V= string.Empty;
          this.KeyFld_3_V= string.Empty;
          this.KeyFld_4_V= string.Empty;
          this.KeyFld_5_V= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int Tcd1Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int DispOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyFld_1_V { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyFld_2_V { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyFld_3_V { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyFld_4_V { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyFld_5_V { get; set; }
    }
}