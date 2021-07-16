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
    public partial class OUAL 
    {
        public OUAL()
        {
          this.ActionDate= DateTime.Now;
          this.ActionType= string.Empty;
          this.ObjectKey= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public short? UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ActionDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActionTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? ObjectId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectKey { get; set; }
    }
}