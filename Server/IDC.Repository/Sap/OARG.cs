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
    public partial class OARG 
    {
        public OARG()
        {
          this.CstGrpName= string.Empty;
          this.GroupNum= string.Empty;
          this.Locked= string.Empty;
          this.DataSource= string.Empty;
          this.cstAllcAcc= string.Empty;
          this.cstExpAcc= string.Empty;
          this.PortAddr= string.Empty;
          this.PortState= string.Empty;
          this.ExciExpAcc= string.Empty;
          this.ExciAlcAcc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstGrpName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Custom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BuyTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OtherTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
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
        public string cstAllcAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string cstExpAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PortAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PortState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExciExpAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExciAlcAcc { get; set; }
    }
}