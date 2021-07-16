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
    public partial class PKL1 
    {
        public PKL1()
        {
          this.PickStatus= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OrderEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OrderLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PickQtty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PickStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RelQtty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInsac { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PrevReleas { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseObject { get; set; }
    }
}