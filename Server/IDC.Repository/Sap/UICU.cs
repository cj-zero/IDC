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
    public partial class UICU 
    {
        public UICU()
        {
          this.TPLName= string.Empty;
          this.TPLDesc= string.Empty;
          this.IsTemplate= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TPLName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TPLDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Parent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsTemplate { get; set; }
    }
}