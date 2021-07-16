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
    public partial class OFML 
    {
        public OFML()
        {
          this.Code= string.Empty;
          this.Descr= string.Empty;
          this.FmlLang= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.FmlType= string.Empty;
          this.IsOrigFml= string.Empty;
        }

        
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
        [Browsable(false)]
        public int? SttId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FmlLang { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FmlType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsOrigFml { get; set; }
    }
}