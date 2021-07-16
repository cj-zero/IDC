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
    public partial class ATHL 
    {
        public ATHL()
        {
          this.RecType= string.Empty;
          this.EffecFrom= DateTime.Now;
          this.Company= string.Empty;
          this.PrivInv= string.Empty;
          this.PrivJE= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.Tourism= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RecType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EffecFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Company { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrivInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrivJE { get; set; }
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
        public string Tourism { get; set; }
    }
}