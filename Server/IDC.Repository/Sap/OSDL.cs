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
    public partial class OSDL 
    {
        public OSDL()
        {
          this.DataSubjct= string.Empty;
          this.SubjctKey= string.Empty;
          this.DataTable= string.Empty;
          this.KeyVal1= string.Empty;
          this.KeyVal2= string.Empty;
          this.KeyVal3= string.Empty;
          this.KeyVal4= string.Empty;
          this.Property= string.Empty;
          this.AccessChnl= string.Empty;
          this.Version= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSubjct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubjctKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataTable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TblKeyCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyVal1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyVal2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyVal3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyVal4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Property { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AccessDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AccessTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AccessChnl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Version { get; set; }
    }
}