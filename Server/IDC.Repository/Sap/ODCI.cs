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
    public partial class ODCI 
    {
        public ODCI()
        {
          this.ConfType= string.Empty;
          this.Code= string.Empty;
          this.Descr= string.Empty;
          this.Export= string.Empty;
          this.Import= string.Empty;
          this.StatCode= string.Empty;
          this.DateFrom= DateTime.Now;
          this.DateTo= DateTime.Now;
          this.TextVal= string.Empty;
          this.ConfID= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ConfType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PrcstVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SuppUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Export { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Import { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StatCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TextVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ConfID { get; set; }
    }
}