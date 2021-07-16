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
    public partial class SIVE 
    {
        public SIVE()
        {
          this.LocCode= string.Empty;
          this.ItemCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TreeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ParentID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LocCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransSeq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LayerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LayerInQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LayerOutQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LayerVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EntryTreeI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LayerCogs { get; set; }
    }
}