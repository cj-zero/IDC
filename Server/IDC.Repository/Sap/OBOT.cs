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
    public partial class OBOT 
    {
        public OBOT()
        {
          this.StatusFrom= string.Empty;
          this.StatusTo= string.Empty;
          this.TranDate= DateTime.Now;
          this.Reconciled= string.Empty;
          this.PostDate= DateTime.Now;
          this.TaxDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StatusFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StatusTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TranDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TranTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Reconciled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
    }
}