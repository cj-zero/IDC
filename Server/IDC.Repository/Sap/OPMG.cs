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
    public partial class OPMG 
    {
        public OPMG()
        {
          this.NAME= string.Empty;
          this.START= DateTime.Now;
          this.TYP= string.Empty;
          this.CARDCODE= string.Empty;
          this.CARDNAME= string.Empty;
          this.WithPhases= string.Empty;
          this.STATUS= string.Empty;
          this.DUEDATE= DateTime.Now;
          this.CLOSING= DateTime.Now;
          this.FIPROJECT= string.Empty;
          this.RISK= string.Empty;
          this.REASON= string.Empty;
          this.Free_Text= string.Empty;
          this.Attachment= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.DPPStatus= string.Empty;
          this.EncryptIV= string.Empty;
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
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TYP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CARDCODE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CARDNAME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CONTACT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TERRITORY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EMPLOYEE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WithPhases { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string STATUS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DUEDATE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CLOSING { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FIPROJECT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RISK { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? INDUSTRY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string REASON { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Free_Text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BPLid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attachment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPPStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}