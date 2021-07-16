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
    public partial class OBAL 
    {
        public OBAL()
        {
          this.ItemCode= string.Empty;
          this.WhsCode= string.Empty;
          this.PeriodID= 0;
          this.EvalSystem= string.Empty;
          this.DtSorting= string.Empty;
          this.LayerID= 0;
          this.CreateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int PeriodID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EvalSystem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DtSorting { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int LayerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
    }
}