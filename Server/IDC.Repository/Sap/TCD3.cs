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
    public partial class TCD3 
    {
        public TCD3()
        {
          this.Tcd2Id= 0;
          this.EfctFrom= DateTime.Now;
          this.EfctTo= DateTime.Now;
          this.TaxCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int Tcd2Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime EfctFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EfctTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCode { get; set; }
    }
}