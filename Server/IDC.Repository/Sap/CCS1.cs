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
    public partial class CCS1 
    {
        public CCS1()
        {
          this.Alert= string.Empty;
          this.NextDate= DateTime.Now;
          this.ExcldZrQty= string.Empty;
          this.Alerted= string.Empty;
          this.ChangExist= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CycleCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Alert { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DestUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? NextDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExcldZrQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Alerted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChangExist { get; set; }
    }
}