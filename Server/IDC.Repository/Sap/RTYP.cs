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
    public partial class RTYP 
    {
        public RTYP()
        {
          this.NAME= string.Empty;
          this.DEFLT_REP= string.Empty;
          this.ADD_NAME= string.Empty;
          this.FRM_TYPE= string.Empty;
          this.MNU_ID= string.Empty;
          this.IS_SYS= string.Empty;
          this.TYPE= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DEFLT_REP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ADD_NAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FRM_TYPE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MNU_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IS_SYS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DEFLT_SEQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TYPE { get; set; }
    }
}