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
    public partial class OBDC 
    {
        public OBDC()
        {
          this.Server= string.Empty;
          this.License= string.Empty;
          this.Company= string.Empty;
          this.DBUser= string.Empty;
          this.DBPassword= string.Empty;
          this.Username= string.Empty;
          this.UPassword= string.Empty;
          this.DBTrusted= string.Empty;
          this.JCOPath= string.Empty;
          this.AddOnIF= string.Empty;
          this.StateFder= string.Empty;
          this.FormatFder= string.Empty;
          this.FileFolder= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Server { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string License { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Company { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DBType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DBUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DBPassword { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UPassword { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DBTrusted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JCOPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Language { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddOnIF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StateFder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FormatFder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FileFolder { get; set; }
    }
}