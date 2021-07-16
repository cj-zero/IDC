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
    public partial class SCL2 
    {
        public SCL2()
        {
          this.ItemCode= string.Empty;
          this.ItemName= string.Empty;
          this.Bill= string.Empty;
          this.ObjectType= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TransToTec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Delivered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RetFromTec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Returned { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Bill { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? QtyToBill { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? QtyToInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VisOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}