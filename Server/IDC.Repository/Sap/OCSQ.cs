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
    public partial class OCSQ 
    {
        public OCSQ()
        {
          this.SeqType= string.Empty;
          this.FormID= string.Empty;
          this.ColToken= string.Empty;
          this.VisInForm= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeqType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FormID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ColToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VisualIndx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VisInForm { get; set; }
    }
}