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
    public partial class OFRM 
    {
        public OFRM()
        {
          this.Name= string.Empty;
          this.Encoding= string.Empty;
          this.FilePath= string.Empty;
          this.IsSystem= string.Empty;
          this.FrmatType= string.Empty;
          this.FrmatStats= string.Empty;
          this.PaymType= string.Empty;
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
        public string Encoding { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FilePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsSystem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrmatType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] FileContnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrmatStats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaymType { get; set; }
    }
}