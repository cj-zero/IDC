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
    public partial class AEXT 
    {
        public AEXT()
        {
          this.ExpName= string.Empty;
          this.ExpAcct= string.Empty;
          this.PaidByComp= string.Empty;
          this.VatGroup= string.Empty;
          this.VatGrpEU= string.Empty;
          this.UpdateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaidByComp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGrpEU { get; set; }
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
    }
}