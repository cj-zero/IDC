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
    public partial class SCL1 
    {
        public SCL1()
        {
          this.objType= string.Empty;
          this.createDate= DateTime.Now;
          this.updateDate= DateTime.Now;
          this.EncryptIV= string.Empty;
          this.U_ZZSXLH= string.Empty;
          this.U_PCBBH= string.Empty;
          this.U_WZWL= string.Empty;
          this.U_PRX_SID= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? solutionID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string objType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? logInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? userSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? createDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? userSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? updateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VisOredr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZZSXLH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PCBBH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_WZWL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_SID { get; set; }
    }
}