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
    public partial class IMPLG 
    {
        public IMPLG()
        {
          this.Owner= string.Empty;
          this.From= string.Empty;
          this.To= string.Empty;
          this.Msg= string.Empty;
          this.Time= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string From { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string To { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Msg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Time { get; set; }
    }
}