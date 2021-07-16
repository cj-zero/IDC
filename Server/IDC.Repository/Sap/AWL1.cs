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
    public partial class AWL1 
    {
        public AWL1()
        {
          this.Candidate= string.Empty;
          this.WasRead= string.Empty;
          this.CandExpr= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WFInstID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Candidate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WasRead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CandExpr { get; set; }
    }
}