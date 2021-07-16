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
    public partial class ORCP 
    {
        public ORCP()
        {
          this.Code= string.Empty;
          this.Dscription= string.Empty;
          this.IsRemoved= string.Empty;
          this.DocObjType= string.Empty;
          this.Frequency= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.UpdateUser= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.DataSource= string.Empty;
          this.PriceUpdat= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dscription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsRemoved { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DraftEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Frequency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Remind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreateUser { get; set; }
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
        public string UpdateUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriceUpdat { get; set; }
    }
}