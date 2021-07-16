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
    public partial class CTBR 
    {
        public CTBR()
        {
          this.VisibleID= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Docking { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LeftID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TopID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RightID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BottomID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VisibleID { get; set; }
    }
}