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
    public partial class USR5 
    {
        public USR5()
        {
          this.ActionBy= string.Empty;
          this.ClientIP= string.Empty;
          this.ClientName= string.Empty;
          this.ReasonDesc= string.Empty;
          this.WinUsrName= string.Empty;
          this.ProcName= string.Empty;
          this.Source= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActionBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ClientIP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ClientName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ProcessID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ReasonID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReasonDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WinSessnID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WinUsrName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProcName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AliveDurtn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogoutTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Source { get; set; }
    }
}