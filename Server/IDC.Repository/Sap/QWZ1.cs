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
    public partial class QWZ1 
    {
        public QWZ1()
        {
          this.FileCode= string.Empty;
          this.IsTemp= string.Empty;
          this.DoJoin= string.Empty;
          this.OuterJoin= string.Empty;
          this.RightJoin= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FileCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsTemp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DoJoin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? JoinToTbl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumOfConds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OuterJoin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RightJoin { get; set; }
    }
}