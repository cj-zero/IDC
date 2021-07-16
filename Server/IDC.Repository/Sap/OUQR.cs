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
    public partial class OUQR 
    {
        public OUQR()
        {
          this.QName= string.Empty;
          this.QString= string.Empty;
          this.QType= string.Empty;
          this.ColumnSize= string.Empty;
          this.QLastDate= DateTime.Now;
          this.Xslt= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QString { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ColumnSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DBType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? QLastDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? QLastTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Xslt { get; set; }
    }
}