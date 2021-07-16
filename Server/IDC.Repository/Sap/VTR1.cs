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
    public partial class VTR1 
    {
        public VTR1()
        {
          this.Sum= string.Empty;
          this.ObjectType= string.Empty;
          this.Selected= string.Empty;
          this.FromObject= string.Empty;
          this.ToObject= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Sum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DispOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Selected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromObject { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ToObject { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Amount { get; set; }
    }
}