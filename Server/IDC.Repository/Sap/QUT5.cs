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
    public partial class QUT5 
    {
        public QUT5()
        {
          this.WTCode= string.Empty;
          this.Category= string.Empty;
          this.Criteria= string.Empty;
          this.Account= string.Empty;
          this.Type= string.Empty;
          this.RoundType= string.Empty;
          this.BaseType= string.Empty;
          this.BaseAbsEnt= 0;
          this.Status= string.Empty;
          this.ObjType= string.Empty;
          this.Doc1LineNo= 0;
          this.WtLineType= string.Empty;
          this.TxblCurr= string.Empty;
          this.DtblCurr= string.Empty;
          this.TdsAcc= string.Empty;
          this.SurAcc= string.Empty;
          this.CessAcc= string.Empty;
          this.HscAcc= string.Empty;
          this.InCSTCode= string.Empty;
          this.OutCSTCode= string.Empty;
          this.TDSType= string.Empty;
          this.IgstAcc= string.Empty;
          this.CgstAcc= string.Empty;
          this.SgstAcc= string.Empty;
          this.UtgstAcc= string.Empty;
          this.CsgstAcc= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxbleAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TxblAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TxblAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? WTAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Criteria { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Account { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RoundType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int BaseAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TrgType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TrgAbsEntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int Doc1LineNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WtLineType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TxblCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DtblCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DtblRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? txblRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DtblAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TdsAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SurAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CessAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HscAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TdsRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SurRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CessRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? HscRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TdsBAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TdsBAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TdsBAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SurBAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SurBAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SurBAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CessBAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CessBAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CessBAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? HscBAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? HscBAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? HscBAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TdsAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TdsAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TdsAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SurAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SurAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SurAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CessAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CessAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CessAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? HscAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? HscAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? HscAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TdsAppl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TdsApplSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TdsApplFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SurAppl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SurApplSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SurApplFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CessAppl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CessApplSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CessApplFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? HscAppl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? HscApplSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? HscApplFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BatchNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InCSTCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OutCSTCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmWTApl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmWTAplSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DpmWTAplFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? WTTypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LnBsAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LnBsAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LnBsAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LnCmTAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LnCmTAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LnCmTAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TDSType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IgstAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IgstAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IgstAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CgstAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CgstAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CgstAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SgstAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SgstAmntSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SgstAmntFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IgstRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CgstRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SgstRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IgstBAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IgstBAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IgstBAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CgstBAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CgstBAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CgstBAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SgstBAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SgstBAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SgstBAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IgstAppl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IgstApplSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IgstApplFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CgstAppl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CgstApplSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CgstApplFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SgstAppl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SgstApplSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SgstApplFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UtgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CsgstAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UtgstAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UtgstAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UtgstAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CsgstAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CsgstAmtSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CsgstAmtFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UtgstRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CsgstRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UtgstBAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UtgstBAmtS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UtgstBAmtF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CsgstBAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CsgstBAmtS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CsgstBAmtF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UtgstAppl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UtgstApplS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? UtgstApplF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CsgstAppl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CsgstApplS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CsgstApplF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}