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
    public partial class TRS2 
    {
        public TRS2()
        {
          this.ObjType= string.Empty;
          this.ParamCode= string.Empty;
          this.PrmValStr= string.Empty;
          this.PrmValTxt= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PrmValAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PrmValNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrmValStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrmValTxt { get; set; }
    }
}