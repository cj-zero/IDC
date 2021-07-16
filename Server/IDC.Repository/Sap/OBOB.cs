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
    public partial class OBOB 
    {
        public OBOB()
        {
          this.TableName= string.Empty;
          this.PrimaryKey= string.Empty;
          this.TitleField= string.Empty;
          this.DescField= string.Empty;
          this.DeviceType= string.Empty;
          this.UsedBy= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TableName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrimaryKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TitleField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DescField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeviceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UsedBy { get; set; }
    }
}