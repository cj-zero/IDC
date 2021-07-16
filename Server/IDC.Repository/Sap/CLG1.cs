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
    public partial class CLG1 
    {
        public CLG1()
        {
          this.Date= DateTime.Now;
          this.Location= string.Empty;
          this.Latitude= string.Empty;
          this.Longitude= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Latitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Longitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? OwnerUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OwnerEmp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
    }
}