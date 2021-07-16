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
    public partial class CSPI 
    {
        public CSPI()
        {
          this.Name= string.Empty;
          this.Type= string.Empty;
          this.Value= string.Empty;
          this.LstUpdDate= DateTime.Now;
          this.CheckSum= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LstUpdDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LstUpdTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckSum { get; set; }
    }
}