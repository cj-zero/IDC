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
    public partial class UIC5 
    {
        public UIC5()
        {
          this.Caption= string.Empty;
          this.GroupItem= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Left { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Right { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Top { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Bottom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CurPan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Caption { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupItem { get; set; }
    }
}