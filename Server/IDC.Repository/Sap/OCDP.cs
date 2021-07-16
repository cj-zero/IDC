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
    public partial class OCDP 
    {
        public OCDP()
        {
          this.ClsDtCode= string.Empty;
          this.BsLineDate= string.Empty;
          this.DueMonth= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ClsDtCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BsLineDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DueMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ExtraMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ExtraDay { get; set; }
    }
}