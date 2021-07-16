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
    public partial class CCPD 
    {
        public CCPD()
        {
          this.ProfitAct= string.Empty;
          this.Ref1= string.Empty;
          this.Ref2= string.Empty;
          this.DueDate= DateTime.Now;
          this.RefDate= DateTime.Now;
          this.TaxDate= DateTime.Now;
          this.Memo= string.Empty;
          this.MarkLine= string.Empty;
          this.ActKeyLine= string.Empty;
          this.CtrlAct= string.Empty;
          this.PL_ACCOUNT= string.Empty;
          this.Ref1_l= string.Empty;
          this.Ref2_l= string.Empty;
          this.Ref3_l= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProfitAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Memo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MarkLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActKeyLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LocBalLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FcBalLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SysBalLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ToPerAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CtrlAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PL_ACCOUNT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref1_l { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref2_l { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref3_l { get; set; }
    }
}