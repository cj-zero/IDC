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
    public partial class OPOS 
    {
        public OPOS()
        {
          this.Model= string.Empty;
          this.ManufSN= string.Empty;
          this.NFModel= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Model { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManufSN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RegNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NFModel { get; set; }
    }
}