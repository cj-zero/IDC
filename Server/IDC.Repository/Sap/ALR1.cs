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
    public partial class ALR1 
    {
        public ALR1()
        {
          this.NameFrom= string.Empty;
          this.AddrFrom= string.Empty;
          this.NameTo= string.Empty;
          this.IsSMS= string.Empty;
          this.Address= string.Empty;
          this.Status= string.Empty;
          this.ObjType= string.Empty;
          this.ObjCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NameFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NameTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsSMS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjCode { get; set; }
    }
}