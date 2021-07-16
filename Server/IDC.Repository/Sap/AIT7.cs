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
    public partial class AIT7 
    {
        public AIT7()
        {
          this.DprStart= DateTime.Now;
          this.DprEnd= DateTime.Now;
          this.DprType= string.Empty;
          this.DprTypeC= string.Empty;
          this.ObjType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VisOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DprStart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DprEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UsefulLife { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RemainLife { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DprType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DprTypeC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UsefulLfeC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RemainDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TotalUnits { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RemainUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StanUnit { get; set; }
    }
}