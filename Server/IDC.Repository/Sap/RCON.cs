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
    public partial class RCON 
    {
        public RCON()
        {
          this.OldServer= string.Empty;
          this.OldDbName= string.Empty;
          this.NewServer= string.Empty;
          this.NewDbName= string.Empty;
          this.UserCode= string.Empty;
          this.SubName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OldServer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OldDbName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NewServer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NewDbName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SubIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubName { get; set; }
    }
}