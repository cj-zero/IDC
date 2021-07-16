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
    public partial class GBI1 
    {
        public GBI1()
        {
          this.AcctBkNo= string.Empty;
          this.AcctBkName= string.Empty;
          this.OrgCode= string.Empty;
          this.CompType= string.Empty;
          this.Industry= string.Empty;
          this.SoftVender= string.Empty;
          this.Version= string.Empty;
          this.FisYear= string.Empty;
          this.LocCurr= string.Empty;
          this.AcctStruct= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctBkNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctBkName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrgCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Industry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SoftVender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FisYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LocCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctStruct { get; set; }
    }
}