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
    public partial class BSJ1 
    {
        public BSJ1()
        {
          this.Type= string.Empty;
          this.Params= string.Empty;
          this.Status= string.Empty;
          this.LastDate= DateTime.Now;
          this.Message= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Params { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RunAs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PostTask { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PreTask { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LastDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LastTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Retry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TimeOut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Message { get; set; }
    }
}