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
    public partial class OTRT 
    {
        public OTRT()
        {
          this.Dscription= string.Empty;
          this.FrgnMode= string.Empty;
          this.Memo= string.Empty;
          this.TransCode= string.Empty;
          this.DataSource= string.Empty;
          this.StampTax= string.Empty;
          this.AutoVat= string.Empty;
          this.ManageWTax= string.Empty;
          this.DeferedTax= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dscription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Memo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransCode { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StampTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManageWTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeferedTax { get; set; }
    }
}