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
    public partial class OPRI 
    {
        public OPRI()
        {
          this.Name= string.Empty;
          this.Desc= string.Empty;
          this.Server= string.Empty;
          this.Selected= string.Empty;
          this.DPrinter= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Server { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Selected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPrinter { get; set; }
    }
}