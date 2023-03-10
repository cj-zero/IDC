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
    public partial class SLR1 
    {
        public SLR1()
        {
          this.PrfCntVal= string.Empty;
          this.PrfCntOrig= string.Empty;
          this.Checked= string.Empty;
          this.Status= string.Empty;
          this.Enabled= string.Empty;
          this.DebitAct= string.Empty;
          this.CreditAct= string.Empty;
          this.RevSides= string.Empty;
          this.Currency= string.Empty;
          this.MainTable= string.Empty;
          this.PKField0= string.Empty;
          this.PKField1= string.Empty;
          this.PKField2= string.Empty;
          this.PKField3= string.Empty;
          this.PKField4= string.Empty;
          this.PKField5= string.Empty;
          this.PKField6= string.Empty;
          this.PKField7= string.Empty;
          this.PKField8= string.Empty;
          this.PKField9= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RuleID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GoalNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TransType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrfCntVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrfCntOrig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Checked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DebitAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CreditAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevSides { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Src { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SrcFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SrcSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SrcCalc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SrcCalcFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SrcCalcSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FinalSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FinalSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? FinalSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MainTable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PKField0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PKField1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PKField2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PKField3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PKField4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PKField5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PKField6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PKField7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PKField8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PKField9 { get; set; }
    }
}