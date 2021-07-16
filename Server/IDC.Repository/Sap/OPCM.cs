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
    public partial class OPCM 
    {
        public OPCM()
        {
          this.IdCode= string.Empty;
          this.PosCode= string.Empty;
          this.PosDesc= string.Empty;
          this.CrCode= string.Empty;
          this.CrDesc= string.Empty;
          this.Remarks= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string IdCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PosCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PosDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks { get; set; }
    }
}