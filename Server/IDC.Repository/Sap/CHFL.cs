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
    public partial class CHFL 
    {
        public CHFL()
        {
          this.FldNum= string.Empty;
          this.DispName= string.Empty;
          this.GroupBy= string.Empty;
          this.Visible= string.Empty;
          this.DispDesc= string.Empty;
          this.SortOrder= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FldNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DispName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Visible { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DispDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SortOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? VisIndex { get; set; }
    }
}