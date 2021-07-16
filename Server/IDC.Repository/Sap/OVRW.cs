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
    public partial class OVRW 
    {
        public OVRW()
        {
          this.RunName= string.Empty;
          this.RunDate= DateTime.Now;
          this.Status= string.Empty;
          this.LedgerType= string.Empty;
          this.DebitAcc= string.Empty;
          this.PostDate= DateTime.Now;
          this.JESeries= string.Empty;
          this.APTISeries= string.Empty;
          this.DateType= string.Empty;
          this.DateFrom= DateTime.Now;
          this.DateTo= DateTime.Now;
          this.IncCorAlt= string.Empty;
          this.RunType= string.Empty;
        }

        
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
        public int? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LedgerType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DebitAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JESeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string APTISeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DateType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncCorAlt { get; set; }
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
        public string RunType { get; set; }
    }
}