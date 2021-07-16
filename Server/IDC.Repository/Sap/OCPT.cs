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
    public partial class OCPT 
    {
        public OCPT()
        {
          this.Name= string.Empty;
          this.Descr= string.Empty;
          this.IsDefault= string.Empty;
          this.IsPublic= string.Empty;
          this.Strategy= string.Empty;
          this.Date= DateTime.Now;
          this.Mnfacturer= string.Empty;
          this.Pubby= string.Empty;
          this.Disabled= string.Empty;
          this.Type= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsDefault { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsPublic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Strategy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? _Top { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? _Left { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? _Width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? _Height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Mnfacturer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Pubby { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Disabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
    }
}