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
    public partial class VPM2 
    {
        public VPM2()
        {
          this.InvType= string.Empty;
          this.IntrsStat= string.Empty;
          this.selfInv= string.Empty;
          this.ObjType= string.Empty;
          this.LinkDate= DateTime.Now;
          this.AmtDifPst= DateTime.Now;
          this.PaidDpm= string.Empty;
          this.DpmPosted= string.Empty;
          this.IsRateDiff= string.Empty;
          this.OcrCode= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.IsSelected= string.Empty;
          this.MIType= string.Empty;
          this.DocSubType= string.Empty;
          this.SpltPmtVAT= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumApplied { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AppliedFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AppliedSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Flags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IntrsStat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? vatApplied { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? vatAppldFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? vatAppldSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string selfInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Dcount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DcntSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DcntSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DcntSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BfDcntSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BfDcntSumF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BfDcntSumS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BfNetDcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BfNetDcntF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BfNetDcntS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PaidSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpAppld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpAppldFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpAppldSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Rounddiff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RounddifFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RounddifSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public short? InstId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtAppld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtAppldFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtAppldSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LinkDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? AmtDifPst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaidDpm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpmPosted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpVatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpVatSumF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExpVatSumS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsRateDiff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtInvCatS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtInvCatSF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WtInvCatSS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? DocTransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MIEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsSelected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTOnHold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTOnhldPst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? baseAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MIType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocSubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpltPmtVAT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}