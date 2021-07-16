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
    public partial class AWD3 
    {
        public AWD3()
        {
          this.WTCode= string.Empty;
          this.KeyPart1= string.Empty;
          this.KeyPart2= string.Empty;
          this.DateFrom= DateTime.Now;
          this.DateTo= DateTime.Now;
          this.DetailType= string.Empty;
          this.DataSource= string.Empty;
          this.UpdateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyPart1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeyPart2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime DateFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DetailType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
    }
}