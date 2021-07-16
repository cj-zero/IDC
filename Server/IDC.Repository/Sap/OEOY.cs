﻿using System;
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
    public partial class OEOY 
    {
        public OEOY()
        {
          this.GenrlDefs= string.Empty;
          this.ReFiles= string.Empty;
          this.ActIndex= string.Empty;
          this.ActFromCod= string.Empty;
          this.ActToCode= string.Empty;
          this.ActGroup= string.Empty;
          this.CrdIndex= string.Empty;
          this.CrdFromCod= string.Empty;
          this.CrdToCode= string.Empty;
          this.CrdToknAnd= string.Empty;
          this.CrdUseGrps= string.Empty;
          this.CrdClsRang= string.Empty;
          this.CrdGrpData= string.Empty;
          this.ItmIndex= string.Empty;
          this.ItmFromCod= string.Empty;
          this.ItmToCode= string.Empty;
          this.ItmToknAnd= string.Empty;
          this.ItmUseGrps= string.Empty;
          this.ItmClsRang= string.Empty;
          this.ItmGrpData= string.Empty;
          this.TransfDoc= string.Empty;
          this.UnDpsChk= string.Empty;
          this.DpsChk= string.Empty;
          this.UnDpsVouch= string.Empty;
          this.DpsVouch= string.Empty;
          this.WorkOrder= string.Empty;
          this.RcrTrt= string.Empty;
          this.Connection= string.Empty;
          this.SpcPrice= string.Empty;
          this.Quotations= string.Empty;
          this.Orders= string.Empty;
          this.DlvrNotes= string.Empty;
          this.DlvrInvocs= string.Empty;
          this.P_Orders= string.Empty;
          this.P_Invoices= string.Empty;
          this.ProdTree= string.Empty;
          this.Subst= string.Empty;
          this.Import= string.Empty;
          this.Revert= string.Empty;
          this.ActBlnc= string.Empty;
          this.ActRef1= string.Empty;
          this.ActRef2= string.Empty;
          this.ActRefDate= DateTime.Now;
          this.ActDueDate= DateTime.Now;
          this.ActMemo= string.Empty;
          this.AOpnBlnAct= string.Empty;
          this.AEquetyAct= string.Empty;
          this.ActExpLine= string.Empty;
          this.ActBlncFrC= string.Empty;
          this.ActBlncToC= string.Empty;
          this.ActBlncGrp= string.Empty;
          this.ActZeroBln= string.Empty;
          this.CrdBlnc= string.Empty;
          this.CrdRef1= string.Empty;
          this.CrdRef2= string.Empty;
          this.CrdRefDate= DateTime.Now;
          this.CrdDueDate= DateTime.Now;
          this.CrdMemo= string.Empty;
          this.COpnBlnAct= string.Empty;
          this.CrdExpLine= string.Empty;
          this.CrdBlncFrC= string.Empty;
          this.CrdBlncToC= string.Empty;
          this.CrdBTknAnd= string.Empty;
          this.CrdBUseGrp= string.Empty;
          this.CrdBClsRng= string.Empty;
          this.CrdBGrpDat= string.Empty;
          this.CrdZeroBln= string.Empty;
          this.ItmBlnc= string.Empty;
          this.ItmRef1= string.Empty;
          this.ItmRef2= string.Empty;
          this.ItmRefDate= DateTime.Now;
          this.ItmMemo= string.Empty;
          this.ItmBlncFrC= string.Empty;
          this.ItmBlncToC= string.Empty;
          this.ItmBTknAnd= string.Empty;
          this.ItmBUseGrp= string.Empty;
          this.ItmBClsRng= string.Empty;
          this.ItmBGrpDat= string.Empty;
          this.ItmZeroPr= string.Empty;
          this.FileReport= string.Empty;
          this.WasGnrlDef= string.Empty;
          this.P_DlvrNots= string.Empty;
          this.Spg= string.Empty;
          this.Pdn= string.Empty;
          this.PdnClosed= string.Empty;
          this.Rpd= string.Empty;
          this.ReportTemp= string.Empty;
          this.Confirmat= string.Empty;
          this.DocDraft= string.Empty;
          this.ChkOutDrft= string.Empty;
          this.OptOpen= string.Empty;
          this.OptClosed= string.Empty;
          this.SerBtchNum= string.Empty;
          this.CorrInvoic= string.Empty;
          this.PaymDraf= string.Empty;
          this.PaymentWiz= string.Empty;
          this.AltItems= string.Empty;
          this.DPIInvoice= string.Empty;
          this.DPIRequest= string.Empty;
          this.Ctr= string.Empty;
          this.Ins= string.Empty;
          this.CorrAPInv= string.Empty;
          this.CorrAPRev= string.Empty;
          this.CorrARInv= string.Empty;
          this.CorrARRev= string.Empty;
          this.UserObj= string.Empty;
          this.AdWrkOrdr= string.Empty;
          this.DPOInvoice= string.Empty;
          this.DPORequest= string.Empty;
          this.P_Quotatio= string.Empty;
          this.WTQ= string.Empty;
          this.Oat= string.Empty;
          this.CPN= string.Empty;
          this.AdvRules= string.Empty;
          this.Prq= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GenrlDefs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReFiles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActFromCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActToCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdFromCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdToCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CrdGrpCust { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CrdGrpVndr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdToknAnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdUseGrps { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdClsRang { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdGrpData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmFromCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmToCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItmGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmToknAnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmUseGrps { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmClsRang { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmGrpData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransfDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UnDpsChk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpsChk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UnDpsVouch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DpsVouch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WorkOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RcrTrt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Connection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpcPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Quotations { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Orders { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DlvrNotes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DlvrInvocs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string P_Orders { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string P_Invoices { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProdTree { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Subst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Import { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Revert { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActBlnc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActRef1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActRef2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ActRefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ActDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AOpnBlnAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AEquetyAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActExpLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActBlncFrC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActBlncToC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActBlncGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActZeroBln { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdBlnc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdRef1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdRef2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CrdRefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CrdDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string COpnBlnAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdExpLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdBlncFrC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdBlncToC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CrdBlncGrC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CrdBlnGrpV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdBTknAnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdBUseGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdBClsRng { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdBGrpDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CrdZeroBln { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmBlnc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmRef1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmRef2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ItmRefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmBlncFrC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmBlncToC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItmBlncGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmBTknAnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmBUseGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmBClsRng { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmBGrpDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItmPlnNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmZeroPr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FileReport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WasGnrlDef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string P_DlvrNots { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Spg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Pdn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PdnClosed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Rpd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReportTemp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Confirmat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocDraft { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChkOutDrft { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OptOpen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OptClosed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SerBtchNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CorrInvoic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserGign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaymDraf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaymentWiz { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AltItems { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPIInvoice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPIRequest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ctr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ins { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CorrAPInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CorrAPRev { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CorrARInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CorrARRev { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserObj { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AdWrkOrdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPOInvoice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPORequest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string P_Quotatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Oat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CPN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AdvRules { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Prq { get; set; }
    }
}