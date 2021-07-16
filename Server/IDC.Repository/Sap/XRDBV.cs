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
    public partial class XRDBV 
    {
        public XRDBV()
        {
          this.DBObjVerDe= string.Empty;
          this.DBObjVerUp= DateTime.Now;
          this.ParVer= string.Empty;
          this.ParVerDesc= string.Empty;
          this.ParVerUpd= DateTime.Now;
          this.Partner= string.Empty;
          this.PartnerDBV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DBObjVerDe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DBObjVerUp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParVer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParVerDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ParVerUpd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Partner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PartnerDBV { get; set; }
    }
}