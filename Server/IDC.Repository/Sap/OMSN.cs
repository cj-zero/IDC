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
    public partial class OMSN 
    {
        public OMSN()
        {
          this.MsnCode= string.Empty;
          this.Descr= string.Empty;
          this.GrpPeriods= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.HldaysProd= string.Empty;
          this.HldaysPurc= string.Empty;
          this.ItmFrom= string.Empty;
          this.ItmTo= string.Empty;
          this.ItmQryGrp= string.Empty;
          this.ExistStock= string.Empty;
          this.PurchOrder= string.Empty;
          this.SalesOrder= string.Empty;
          this.WorkOrder= string.Empty;
          this.MinStckLvl= string.Empty;
          this.SortBy= string.Empty;
          this.ItmReq= string.Empty;
          this.Simulation= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.UpdateBy= string.Empty;
          this.LastExecDa= DateTime.Now;
          this.AllItems= string.Empty;
          this.ByCompany= string.Empty;
          this.IncHisData= string.Empty;
          this.ResInv= string.Empty;
          this.Wtrq= string.Empty;
          this.InvtLevel= string.Empty;
          this.RcmPO= string.Empty;
          this.RcmWO= string.Empty;
          this.RcmWTRQ= string.Empty;
          this.RCMDefWhs= string.Empty;
          this.OnlyNettbl= string.Empty;
          this.ExpandedPO= string.Empty;
          this.ExpandedSO= string.Empty;
          this.RcmCalDate= DateTime.Now;
          this.PurchOAT= string.Empty;
          this.SalesOAT= string.Empty;
          this.Rots= string.Empty;
          this.ExpdResINV= string.Empty;
          this.ExpdWOR= string.Empty;
          this.IgnoreCLT= string.Empty;
          this.PurchReq= string.Empty;
          this.PurchQuota= string.Empty;
          this.SalesQuota= string.Empty;
          this.ExpdPurReq= string.Empty;
          this.ExpdPQuota= string.Empty;
          this.ExpdSQuota= string.Empty;
          this.ExpdPAgree= string.Empty;
          this.ExpdSAgree= string.Empty;
          this.ExpdTraReq= string.Empty;
          this.DisSelItem= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MsnCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GrpPeriods { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PeriodsLen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MaxLdTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HldaysProd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HldaysPurc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ItmGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmQryGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExistStock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurchOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SalesOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WorkOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MinStckLvl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FCTAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SortBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmReq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Simulation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UpdateBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LastExecDa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AllItems { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ByCompany { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncHisData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Wtrq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvtLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RcmPO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RcmWO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RcmWTRQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RCMDefWhs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OnlyNettbl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpandedPO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpandedSO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RcmCalDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RcmCalTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurchOAT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SalesOAT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Rots { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpdResINV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpdWOR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IgnoreCLT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurchReq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurchQuota { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SalesQuota { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpdPurReq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpdPQuota { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpdSQuota { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpdPAgree { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpdSAgree { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpdTraReq { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DisSelItem { get; set; }
    }
}