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
    public partial class OSQR 
    {
        public OSQR()
        {
          this.QName= string.Empty;
          this.QString= string.Empty;
          this.QType= string.Empty;
          this.ColumnSize= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? QCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QString { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ColumnSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DBType { get; set; }
    }
}