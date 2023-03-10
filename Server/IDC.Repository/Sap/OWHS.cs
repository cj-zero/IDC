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
    public partial class OWHS 
    {
        public OWHS()
        {
          this.WhsName= string.Empty;
          this.Grp_Code= string.Empty;
          this.BalInvntAc= string.Empty;
          this.SaleCostAc= string.Empty;
          this.TransferAc= string.Empty;
          this.Locked= string.Empty;
          this.DataSource= string.Empty;
          this.RevenuesAc= string.Empty;
          this.VarianceAc= string.Empty;
          this.DecreasAc= string.Empty;
          this.IncreasAc= string.Empty;
          this.ReturnAc= string.Empty;
          this.ExpensesAc= string.Empty;
          this.EURevenuAc= string.Empty;
          this.EUExpensAc= string.Empty;
          this.FrRevenuAc= string.Empty;
          this.FrExpensAc= string.Empty;
          this.VatGroup= string.Empty;
          this.Street= string.Empty;
          this.Block= string.Empty;
          this.ZipCode= string.Empty;
          this.City= string.Empty;
          this.County= string.Empty;
          this.Country= string.Empty;
          this.State= string.Empty;
          this.DropShip= string.Empty;
          this.ExmptIncom= string.Empty;
          this.UseTax= string.Empty;
          this.PriceDifAc= string.Empty;
          this.ExchangeAc= string.Empty;
          this.BalanceAcc= string.Empty;
          this.PurchaseAc= string.Empty;
          this.PAReturnAc= string.Empty;
          this.PurchOfsAc= string.Empty;
          this.FedTaxID= string.Empty;
          this.Building= string.Empty;
          this.ShpdGdsAct= string.Empty;
          this.VatRevAct= string.Empty;
          this.DecresGlAc= string.Empty;
          this.IncresGlAc= string.Empty;
          this.Nettable= string.Empty;
          this.StokRvlAct= string.Empty;
          this.StkOffsAct= string.Empty;
          this.WipAcct= string.Empty;
          this.WipVarAcct= string.Empty;
          this.CostRvlAct= string.Empty;
          this.CstOffsAct= string.Empty;
          this.ExpClrAct= string.Empty;
          this.ExpOfstAct= string.Empty;
          this.objType= string.Empty;
          this.createDate= DateTime.Now;
          this.updateDate= DateTime.Now;
          this.ARCMAct= string.Empty;
          this.ARCMFrnAct= string.Empty;
          this.ARCMEUAct= string.Empty;
          this.ARCMExpAct= string.Empty;
          this.APCMAct= string.Empty;
          this.APCMFrnAct= string.Empty;
          this.APCMEUAct= string.Empty;
          this.RevRetAct= string.Empty;
          this.OwnerCode= string.Empty;
          this.NegStckAct= string.Empty;
          this.StkInTnAct= string.Empty;
          this.AddrType= string.Empty;
          this.StreetNo= string.Empty;
          this.PurBalAct= string.Empty;
          this.Excisable= string.Empty;
          this.WhICenAct= string.Empty;
          this.WhOCenAct= string.Empty;
          this.WhShipTo= string.Empty;
          this.WipOffset= string.Empty;
          this.StockOffst= string.Empty;
          this.Shipper= string.Empty;
          this.BinActivat= string.Empty;
          this.BinSeptor= string.Empty;
          this.DftBinEnfd= string.Empty;
          this.ManageSnB= string.Empty;
          this.RecBinEnab= string.Empty;
          this.GlblLocNum= string.Empty;
          this.RecvEmpBin= string.Empty;
          this.Inactive= string.Empty;
          this.RecvMaxQty= string.Empty;
          this.RecvMaxWT= string.Empty;
          this.RecvUpTo= string.Empty;
          this.FreeChrgSA= string.Empty;
          this.FreeChrgPU= string.Empty;
          this.TaxOffice= string.Empty;
          this.Address2= string.Empty;
          this.Address3= string.Empty;
          this.External= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IntrnalKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Grp_Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BalInvntAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SaleCostAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TransferAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevenuesAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VarianceAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DecreasAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncreasAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReturnAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpensesAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EURevenuAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EUExpensAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrRevenuAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrExpensAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Street { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Block { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ZipCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string County { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DropShip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExmptIncom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriceDifAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExchangeAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BalanceAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurchaseAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PAReturnAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurchOfsAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FedTaxID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Building { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShpdGdsAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatRevAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DecresGlAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncresGlAc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Nettable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StokRvlAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StkOffsAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WipAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WipVarAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostRvlAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstOffsAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpClrAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpOfstAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string objType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? logInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? createDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? userSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? updateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARCMAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARCMFrnAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARCMEUAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ARCMExpAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string APCMAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string APCMFrnAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string APCMEUAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevRetAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BPLid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OwnerCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NegStckAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StkInTnAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddrType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StreetNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurBalAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Excisable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhICenAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhOCenAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhShipTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WipOffset { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StockOffst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StorKeeper { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Shipper { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinActivat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BinSeptor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DftBinAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DftBinEnfd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? AutoIssMtd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManageSnB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RecItemsBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RecBinEnab { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GlblLocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RecvEmpBin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Inactive { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RecvMaxQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? AutoRecvMd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RecvMaxWT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RecvUpTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeChrgSA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeChrgPU { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxOffice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string External { get; set; }
    }
}