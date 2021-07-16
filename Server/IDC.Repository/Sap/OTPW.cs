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
    public partial class OTPW 
    {
        public OTPW()
        {
          this.WizName= string.Empty;
          this.WizStatus= string.Empty;
          this.CreateDate= DateTime.Now;
          this.SaveDate= DateTime.Now;
          this.ExecDate= DateTime.Now;
          this.WizDate= DateTime.Now;
          this.SeriesStr= string.Empty;
          this.SubStr= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WizNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WizName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WizStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SaveDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ExecDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? JETransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? WizDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RG23APart2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RG23CPart2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SeqCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Serial { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeriesStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubStr { get; set; }
    }
}