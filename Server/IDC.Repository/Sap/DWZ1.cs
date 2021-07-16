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
    public partial class DWZ1 
    {
        public DWZ1()
        {
          this.DunAddr= string.Empty;
          this.CheckedBP= string.Empty;
          this.FaxNum= string.Empty;
          this.Email= string.Empty;
          this.DPPStatus= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DunAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckedBP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FaxNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPPStatus { get; set; }
    }
}