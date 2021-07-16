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
    public partial class OSLP 
    {
        public OSLP()
        {
          this.SlpName= string.Empty;
          this.Memo= string.Empty;
          this.Locked= string.Empty;
          this.DataSource= string.Empty;
          this.Active= string.Empty;
          this.Telephone= string.Empty;
          this.Mobil= string.Empty;
          this.Fax= string.Empty;
          this.Email= string.Empty;
          this.DPPStatus= string.Empty;
          this.EncryptIV= string.Empty;
          this.U_PRX_SID= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SlpName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Memo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Commission { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GroupCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EmpID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Telephone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Mobil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Fax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPPStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_SID { get; set; }
    }
}