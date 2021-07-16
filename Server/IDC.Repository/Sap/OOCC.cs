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
    public partial class OOCC 
    {
        public OOCC()
        {
          this.Code= string.Empty;
          this.Dscription= string.Empty;
          this.Note= string.Empty;
          this.ReqBoeSt= string.Empty;
          this.IsMovement= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dscription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Note { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReqBoeSt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsMovement { get; set; }
    }
}