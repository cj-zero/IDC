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
    public partial class OPPA 
    {
        public OPPA()
        {
          this.SecLevel= string.Empty;
          this.PwdExample= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SecLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PwdExp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PwdMinLen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MinUppers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MinLowCase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MinDigits { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MinNonAlph { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumPrevPwd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumAuthLoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PwdExample { get; set; }
    }
}