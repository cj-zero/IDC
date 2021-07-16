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
    public partial class OPQW 
    {
        public OPQW()
        {
          this.SetName= string.Empty;
          this.SetDesc= string.Empty;
          this.CreateDate= DateTime.Now;
          this.ModifyDate= DateTime.Now;
          this.CreatDraft= string.Empty;
          this.GroupBy= string.Empty;
          this.ValidUntil= DateTime.Now;
          this.ReqDate= DateTime.Now;
          this.BaseOn= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SetName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SetDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ModifyDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreatDraft { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValidUntil { get; set; }
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
        public System.DateTime? ReqDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseOn { get; set; }
    }
}