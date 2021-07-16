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
    public partial class GDP2 
    {
        public GDP2()
        {
          this.NatObjType= string.Empty;
          this.NatObjArr= 0;
          this.NatObjKey1= string.Empty;
          this.NatObjKey2= string.Empty;
          this.ErrorStr= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NatObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int NatObjArr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NatObjKey1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NatObjKey2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ErrorStr { get; set; }
    }
}