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
    public partial class ISW2 
    {
        public ISW2()
        {
          this.CommCode= string.Empty;
          this.SerCode= string.Empty;
          this.AddMUnit= string.Empty;
          this.OriRegSta= string.Empty;
          this.DstRegSta= string.Empty;
          this.CtryOrig= string.Empty;
          this.SerSupplM= string.Empty;
          this.SerPymMeth= string.Empty;
          this.ItemType= string.Empty;
          this.ItemName= string.Empty;
          this.DestRegCry= string.Empty;
          this.OrigRegCry= string.Empty;
          this.UseWeight= string.Empty;
          this.StatCode= string.Empty;
          this.NatOfTrans= string.Empty;
          this.StatProc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CommCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SerCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddMUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FactorAM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OriRegSta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DstRegSta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CtryOrig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SerSupplM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SerPymMeth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DestRegCry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrigRegCry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseWeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StatCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NatOfTrans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StatProc { get; set; }
    }
}