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
    public partial class OFLR 
    {
        public OFLR()
        {
          this.FilterName= string.Empty;
          this.TableName= string.Empty;
          this.StatCol= string.Empty;
          this.UnitCol= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FilterName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TableName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? VisOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StatCol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UnitCol { get; set; }
    }
}