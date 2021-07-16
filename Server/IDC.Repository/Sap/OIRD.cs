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
    public partial class OIRD 
    {
        public OIRD()
        {
          this.Revision= string.Empty;
          this.Title= string.Empty;
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
        public int? Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? CategoryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Revision { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] Definition { get; set; }
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