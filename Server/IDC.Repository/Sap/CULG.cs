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
    public partial class CULG 
    {
        public CULG()
        {
          this.TableId= string.Empty;
          this.OnCreate= string.Empty;
          this.ErrLevel= string.Empty;
          this.InQuery= string.Empty;
          this.ErrMessage= string.Empty;
          this.UpgStart= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VersFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VersTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TableId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OnCreate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ErrLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InQuery { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ErrMessage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UpgStart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UserID { get; set; }
    }
}