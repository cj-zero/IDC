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
    public partial class OIRC 
    {
        public OIRC()
        {
          this.Name= string.Empty;
          this.ResKey= string.Empty;
          this.Comment= string.Empty;
          this.System= string.Empty;
          this.CreateBy= string.Empty;
          this.CreateDate= DateTime.Now;
          this.ModifyBy= string.Empty;
          this.ModifyDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? ParentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string System { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreateBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ModifyBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ModifyDate { get; set; }
    }
}