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
    public partial class SCR2 
    {
        public SCR2()
        {
          this.TransTpFld= string.Empty;
          this.PrfCntVal= string.Empty;
          this.PrfCntFld= string.Empty;
          this.DebitAct= string.Empty;
          this.CreditAct= string.Empty;
          this.RevSides= string.Empty;
          this.SrcTable= string.Empty;
          this.SrcField= string.Empty;
          this.SrcFieldFC= string.Empty;
          this.SrcFieldSC= string.Empty;
          this.Calc= string.Empty;
          this.CalcFC= string.Empty;
          this.CalcSC= string.Empty;
          this.CalcCond= string.Empty;
          this.CalcCondFC= string.Empty;
          this.CalcCondSC= string.Empty;
          this.CurrFld= string.Empty;
          this.CallProc= string.Empty;
          this.ExtCond= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TransTpVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransTpFld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrfCntVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrfCntFld { get; set; }
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
        public string SrcTable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcFieldFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcFieldSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Calc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CalcFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CalcSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CalcCond { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CalcCondFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CalcCondSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CurrFld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CallProc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtCond { get; set; }
    }
}