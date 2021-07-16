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
    public partial class OIMT 
    {
        public OIMT()
        {
          this.ValuatType= string.Empty;
          this.TransType= 0;
          this.LocalizId= string.Empty;
          this.JEPosting= string.Empty;
          this.Total= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValuatType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int TransType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public string LocalizId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JEPosting { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LineActTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short TmpType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Total { get; set; }
    }
}