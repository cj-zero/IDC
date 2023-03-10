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
    public partial class ODUT 
    {
        public ODUT()
        {
          this.TermName= string.Empty;
          this.GrpMethod= string.Empty;
          this.RemIntrst= string.Empty;
          this.XchgOrig= string.Empty;
          this.FeeCurr= string.Empty;
          this.BalCurr= string.Empty;
          this.CalcIntr= string.Empty;
          this.LetterFrmt= string.Empty;
          this.HiLtrFrmt= string.Empty;
          this.DateCalInt= string.Empty;
          this.AutoPost= string.Empty;
          this.IntrAcc= string.Empty;
          this.FeeAcc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TermName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GrpMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? YearDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? MonthDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RemIntrst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string XchgOrig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? YearlyRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? MaxLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalFee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FeeCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinBalance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BalCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CalcIntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LetterFrmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HiLtrFrmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DateCalInt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AutoPost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IntrAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FeeAcc { get; set; }
    }
}