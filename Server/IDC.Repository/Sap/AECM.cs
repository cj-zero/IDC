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
    public partial class AECM 
    {
        public AECM()
        {
          this.Descr= string.Empty;
          this.IsActive= string.Empty;
          this.LHost= string.Empty;
          this.LTimeout= string.Empty;
          this.RHost= string.Empty;
          this.RTimeout= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UIOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? StrIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsActive { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LHost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LPID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LTimeout { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RHost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RPID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RTimeout { get; set; }
    }
}