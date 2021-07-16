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
    public partial class OBMI 
    {
        public OBMI()
        {
          this.IndexType= 0;
          this.Code= string.Empty;
          this.Descr= string.Empty;
          this.RefIndCod1= string.Empty;
          this.RefIndCod2= string.Empty;
          this.RefIndCod3= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int IndexType { get; set; }
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
        public string RefIndCod1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefIndCod2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefIndCod3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
    }
}