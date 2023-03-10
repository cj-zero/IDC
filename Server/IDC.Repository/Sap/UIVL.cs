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
    public partial class UIVL 
    {
        public UIVL()
        {
          this.BASE_REF= string.Empty;
          this.DocDate= DateTime.Now;
          this.ItemCode= string.Empty;
          this.Currency= string.Empty;
          this.TrnsfrAct= string.Empty;
          this.PriceDifAc= string.Empty;
          this.VarianceAc= string.Empty;
          this.ReturnAct= string.Empty;
          this.ExcRateAct= string.Empty;
          this.ClearAct= string.Empty;
          this.CostAct= string.Empty;
          this.WipAct= string.Empty;
          this.CreateDate= DateTime.Now;
          this.InvntAct= string.Empty;
          this.NegStckAct= string.Empty;
          this.IOffIncAcc= string.Empty;
          this.DOffDecAcc= string.Empty;
          this.DecAcc= string.Empty;
          this.WipVarAcc= string.Empty;
          this.IncAct= string.Empty;
          this.ExpCAcc= string.Empty;
          this.CostMethod= string.Empty;
          this.LocCode= string.Empty;
          this.DataSource= string.Empty;
          this.PostStatus= string.Empty;
          this.PAOffAcc= string.Empty;
          this.PAAcc= string.Empty;
          this.LinkArc= string.Empty;
          this.VersionNum= string.Empty;
          this.WipDebCred= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BASE_REF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OutQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrnsfrAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriceDifAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VarianceAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReturnAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExcRateAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ClearAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WipAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenStock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PriceDiff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvntAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SubLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AppObjLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Expenses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenExp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Allocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenAlloc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpAlloc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OExpAlloc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenPDiff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExchDiff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenEDiff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NegInvAdjs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenNegInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NegStckAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BTransVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VarVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BExpVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CogsVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BNegAVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IOffIncAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IOffIncVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DOffDecAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DOffDecVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DecAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DecVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WipVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WipVarAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WipVarVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IncVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpCAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MessageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LocCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PostStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumStock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenCogs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TreeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ParentID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PAOffAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PAOffVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenPAOff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PAAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PAVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenPA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkArc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VersionNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BSubLineNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WipDebCred { get; set; }
    }
}