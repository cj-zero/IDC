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
    public partial class CRD9 
    {
        public CRD9()
        {
          this.ISCRYOrig= string.Empty;
          this.ISDomFrgld= string.Empty;
          this.ISRelevant= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISTransMod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISIncoterm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISNatTrans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISStatProc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISCustProc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISCRYOrig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISPort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISDomFrgld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISRelevant { get; set; }
    }
}