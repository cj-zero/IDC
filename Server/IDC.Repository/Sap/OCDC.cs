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
    public partial class OCDC 
    {
        public OCDC()
        {
          this.TableDesc= string.Empty;
          this.ByDate= string.Empty;
          this.Freight= string.Empty;
          this.Tax= string.Empty;
          this.VatCrctn= string.Empty;
          this.BaseDate= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TableDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ByDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Freight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Tax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatCrctn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseDate { get; set; }
    }
}