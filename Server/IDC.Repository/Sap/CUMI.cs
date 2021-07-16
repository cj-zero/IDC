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
    public partial class CUMI 
    {
        public CUMI()
        {
          this.Name_= string.Empty;
          this.Type_= string.Empty;
          this.ObjType= string.Empty;
          this.Key_= string.Empty;
          this.RepPath= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name_ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? FatherId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SortNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type_ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Key_ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? FormMenuId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FormNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RepPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Levels { get; set; }
    }
}