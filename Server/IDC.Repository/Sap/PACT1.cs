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
    public partial class PACT1 
    {
        public PACT1()
        {
          this.SrcObjId= string.Empty;
          this.SrcType= string.Empty;
          this.TgtObjId= string.Empty;
          this.TgtType= string.Empty;
          this.ActEntry= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string SrcObjId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string TgtObjId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TgtType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActEntry { get; set; }
    }
}