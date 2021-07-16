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
    public partial class ADNF 
    {
        public ADNF()
        {
          this.NCMEntry= 0;
          this.DNFCode= string.Empty;
          this.DNFUoM= string.Empty;
          this.UpdateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int NCMEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DNFCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DNFUoM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DNFFactor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
    }
}