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
    public partial class PMC5 
    {
        public PMC5()
        {
          this.ActType= string.Empty;
          this.LaborItem= string.Empty;
          this.Chargeable= string.Empty;
          this.Absence= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LaborItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Chargeable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Absence { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AbsenceID { get; set; }
    }
}