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
    public partial class OULA 
    {
        public OULA()
        {
          this.Signed= string.Empty;
          this.Checked= string.Empty;
          this.EULAType= string.Empty;
          this.Licensor= string.Empty;
          this.Licensee= string.Empty;
          this.InstallNo= string.Empty;
          this.Signer= string.Empty;
          this.UFunction= string.Empty;
          this.Username= string.Empty;
          this.SignDate= DateTime.Now;
          this.DocVer= string.Empty;
          this.EULAFormat= string.Empty;
          this.Checksum= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Signed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Checked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EULAType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Licensor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Licensee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InstallNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Signer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UFunction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SignDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocVer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] EULADoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EULAFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Checksum { get; set; }
    }
}