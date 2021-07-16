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
    public partial class AQAG 
    {
        public AQAG()
        {
          this.AUTHGRPCD= string.Empty;
          this.AUTHGRPN= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.Deleted= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AUTHGRPCD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AUTHGRPN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Deleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SnapShotID { get; set; }
    }
}