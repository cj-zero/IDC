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
    public partial class OARI 
    {
        public OARI()
        {
          this.EGroup= string.Empty;
          this.AStatus= string.Empty;
          this.IsAdd64= string.Empty;
          this.AddPlat= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EventOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsAdd64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddPlat { get; set; }
    }
}