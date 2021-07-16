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
    public partial class PMG9 
    {
        public PMG9()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TargetNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TargetLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SubProjID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SourceAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SourceNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SourceLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Charged { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ChargedQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DestType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DestArr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DestAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DestLine { get; set; }
    }
}