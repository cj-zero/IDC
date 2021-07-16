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
    public partial class OCRT 
    {
        public OCRT()
        {
          this.NodeStr= string.Empty;
          this.TableName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NodeStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FatherID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TableName { get; set; }
    }
}