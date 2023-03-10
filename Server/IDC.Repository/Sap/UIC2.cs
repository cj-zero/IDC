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
    public partial class UIC2 
    {
        public UIC2()
        {
          this.Visible= string.Empty;
          this.VisibleCtl= string.Empty;
          this.Editable= string.Empty;
          this.EditbleCtl= string.Empty;
          this.UDF= string.Empty;
          this.TableName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Visible { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VisibleCtl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Editable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EditbleCtl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Left { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Top { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Right { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Bottom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FromPane { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ToPane { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UDF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TableName { get; set; }
    }
}