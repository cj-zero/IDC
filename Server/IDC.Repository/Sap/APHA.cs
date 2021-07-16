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
    public partial class APHA 
    {
        public APHA()
        {
          this.NAME= string.Empty;
          this.START= DateTime.Now;
          this.STATUS= string.Empty;
          this.END= DateTime.Now;
          this.DUEDATE= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OWNER { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? START { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FINISHED { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ParentID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ProjectID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TYP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CONTRIB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string STATUS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? END { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? COST { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PLANNED { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DUEDATE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UpdateTS { get; set; }
    }
}