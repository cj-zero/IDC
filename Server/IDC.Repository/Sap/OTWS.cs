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
    public partial class OTWS 
    {
        public OTWS()
        {
          this.TwsName= string.Empty;
          this.TwsURL= string.Empty;
          this.TwsDescrip= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TwsName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TwsURL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TwsDescrip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
    }
}