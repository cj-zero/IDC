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
    public partial class OCNT 
    {
        public OCNT()
        {
          this.Code= string.Empty;
          this.Country= string.Empty;
          this.State= string.Empty;
          this.Name= string.Empty;
          this.TaxZone= string.Empty;
          this.IbgeCode= string.Empty;
          this.GiaCode= string.Empty;
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
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxZone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IbgeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GiaCode { get; set; }
    }
}