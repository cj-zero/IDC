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
    public partial class LIVI 
    {
        public LIVI()
        {
          this.PatchLevel= string.Empty;
          this.Comment= string.Empty;
          this.LoadCustom= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.InitMap= string.Empty;
          this.InitStd= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PatchLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LoadCustom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LastMsgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InitMap { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InitStd { get; set; }
    }
}