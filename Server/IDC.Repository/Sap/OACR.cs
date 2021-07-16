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
    public partial class OACR 
    {
        public OACR()
        {
          this.Name= string.Empty;
          this.PostingAct= string.Empty;
          this.CalcAcct= string.Empty;
          this.InterimAct= string.Empty;
          this.Locked= string.Empty;
          this.DataSource= string.Empty;
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
        public string PostingAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CalcAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InterimAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
    }
}