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
    public partial class IMGLG 
    {
        public IMGLG()
        {
          this.From= string.Empty;
          this.Msg= string.Empty;
          this.Time= DateTime.Now;
          this.Nty= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string From { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? GrpId { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Nty { get; set; }
    }
}