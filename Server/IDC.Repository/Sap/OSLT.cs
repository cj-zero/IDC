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
    public partial class OSLT 
    {
        public OSLT()
        {
          this.ItemCode= string.Empty;
          this.DateCreate= DateTime.Now;
          this.DateUpdate= DateTime.Now;
          this.Subject= string.Empty;
          this.Symptom= string.Empty;
          this.Cause= string.Empty;
          this.Descriptio= string.Empty;
          this.Attachment= string.Empty;
          this.Transfered= string.Empty;
          this.U_PRX_SID= string.Empty;
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
        public int? StatusNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateCreate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UpdateBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateUpdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Subject { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Symptom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Cause { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descriptio { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Instance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_SID { get; set; }
    }
}