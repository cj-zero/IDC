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
    public partial class BOX1 
    {
        public BOX1()
        {
          this.BoxMember= string.Empty;
          this.VATMember= string.Empty;
          this.FormulSign= string.Empty;
          this.EffecDate= DateTime.Now;
          this.TaxType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoxMember { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VATMember { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FormulSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EffecDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxType { get; set; }
    }
}