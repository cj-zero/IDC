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
    public partial class OPCI 
    {
        public OPCI()
        {
          this.InstName= string.Empty;
          this.InstDesc= string.Empty;
          this.Creator= string.Empty;
          this.Status= string.Empty;
          this.StartDate= DateTime.Now;
          this.CloseDate= DateTime.Now;
          this.Memo= string.Empty;
          this.Attachment= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TemplateFk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InstDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Creator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CloseDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CloPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Memo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attachment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
    }
}