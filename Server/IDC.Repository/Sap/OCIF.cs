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
    public partial class OCIF 
    {
        public OCIF()
        {
          this.ISTable= string.Empty;
          this.ISField= string.Empty;
          this.FieldDesc= string.Empty;
          this.FlLocation= string.Empty;
          this.FldSource= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISTable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FieldDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FlLocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FldSource { get; set; }
    }
}