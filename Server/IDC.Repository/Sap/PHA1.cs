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
    public partial class PHA1 
    {
        public PHA1()
        {
          this.START= DateTime.Now;
          this.CLOSE= DateTime.Now;
          this.FINISHDATE= DateTime.Now;
          this.DSCRIPTION= string.Empty;
          this.FINISH= string.Empty;
          this.StDp1Type= string.Empty;
          this.StDp2Type= string.Empty;
          this.StDp3Type= string.Empty;
          this.StDp4Type= string.Empty;
          this.UniqueID= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? POS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? START { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CLOSE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FINISHDATE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Task { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DSCRIPTION { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EXPCOSTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InvAmtAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenAmtAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InvAmtAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenAmtAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PERCENT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FINISH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OWNER { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StageDep1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StageDep2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StageDep3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StageDep4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StDp1Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StDp2Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StDp3Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StDp4Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StDp1Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StDp2Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StDp3Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StDp4Abs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UniqueID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}