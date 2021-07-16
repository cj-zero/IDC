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
    public partial class ATS1 
    {
        public ATS1()
        {
          this.VehicleTyp= string.Empty;
          this.VehicleNo= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VehicleTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VehicleNo { get; set; }
    }
}