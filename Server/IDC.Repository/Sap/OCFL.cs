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
    public partial class OCFL 
    {
        public OCFL()
        {
          this.DateID= DateTime.Now;
          this.Dscription= string.Empty;
          this.Project= string.Empty;
          this.CredCur= string.Empty;
          this.DebCur= string.Empty;
          this.Frequency= string.Empty;
          this.EndDate= DateTime.Now;
          this.OcrCode= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dscription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Credit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CredCur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Debit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DebCur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SecLevel { get; set; }
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
        public System.DateTime? EndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode5 { get; set; }
    }
}