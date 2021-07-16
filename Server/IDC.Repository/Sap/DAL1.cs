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
    public partial class DAL1 
    {
        public DAL1()
        {
          this.ItemID= string.Empty;
          this.ObjName= string.Empty;
          this.PropName= string.Empty;
          this.QueryCol= string.Empty;
          this.MobDesc= string.Empty;
          this.IsUDF= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LinkEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PropName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QueryCol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MobDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsUDF { get; set; }
    }
}