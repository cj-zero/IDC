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
    public partial class OFRC 
    {
        public OFRC()
        {
          this.Name= string.Empty;
          this.FrgnName= string.Empty;
          this.Active= string.Empty;
          this.HasSons= string.Empty;
          this.SubSum= string.Empty;
          this.SubName= string.Empty;
          this.Furmula= string.Empty;
          this.OP_1= string.Empty;
          this.OP_2= string.Empty;
          this.OP_3= string.Empty;
          this.OP_4= string.Empty;
          this.OP_5= string.Empty;
          this.OP_6= string.Empty;
          this.OP_7= string.Empty;
          this.OP_8= string.Empty;
          this.OP_9= string.Empty;
          this.OP_10= string.Empty;
          this.OP_11= string.Empty;
          this.OP_12= string.Empty;
          this.OP_13= string.Empty;
          this.OP_14= string.Empty;
          this.OP_15= string.Empty;
          this.OP_16= string.Empty;
          this.OP_17= string.Empty;
          this.OP_18= string.Empty;
          this.OP_19= string.Empty;
          this.OP_20= string.Empty;
          this.OP_21= string.Empty;
          this.OP_22= string.Empty;
          this.OP_23= string.Empty;
          this.OP_24= string.Empty;
          this.ProfitLoss= string.Empty;
          this.MoveNeg= string.Empty;
          this.Dummy= string.Empty;
          this.HideAct= string.Empty;
          this.LineNum= string.Empty;
          this.IndentChar= string.Empty;
          this.Reversal= string.Empty;
          this.TextTitle= string.Empty;
          this.SumType= string.Empty;
          this.NetIncome= string.Empty;
          this.CustName= string.Empty;
          this.ExtFromBS= string.Empty;
          this.ExtData= string.Empty;
          this.LegalRef= string.Empty;
          this.SignAggr= string.Empty;
          this.Mandatory= string.Empty;
          this.AcctReq= string.Empty;
          this.NotPermit= string.Empty;
          this.KPIFactor= string.Empty;
          this.CatCode= string.Empty;
          this.CatClass= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Levels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FatherNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HasSons { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? VisOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Furmula { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Param_25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OP_24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProfitLoss { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MoveNeg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dummy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HideAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ToGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ToTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IndentChar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Reversal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TextTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SumType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NetIncome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? PLTempId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CustName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtFromBS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LegalRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public short? PLCatId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SignAggr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Mandatory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctReq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NotPermit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KPIFactor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CatCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CatClass { get; set; }
    }
}