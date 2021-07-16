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
    public partial class OTRB 
    {
        public OTRB()
        {
          this.GPCCode= string.Empty;
          this.PrdType= string.Empty;
          this.PrdDate= DateTime.Now;
          this.RunName= string.Empty;
          this.RunDate= DateTime.Now;
          this.Status= string.Empty;
          this.StateTax= string.Empty;
          this.DueDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? BPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? GPCId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GPCCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Year { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrdType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PrdNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PrdDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RunName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RunDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StateTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
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
        public short? CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
    }
}