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
    public partial class GBI2 
    {
        public GBI2()
        {
          this.AcctCode= string.Empty;
          this.AcctName= string.Empty;
          this.EvalSign= string.Empty;
          this.AddField= string.Empty;
          this.AcctType= string.Empty;
          this.MesurUnit= string.Empty;
          this.BlDirect= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StrucLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EvalSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MesurUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlDirect { get; set; }
    }
}