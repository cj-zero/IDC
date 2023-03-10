using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Dapper.Contrib.Extensions;
using IDC.Repository.Dapper;

namespace IDC.Repository.Entities.Sap
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("SapDbContext", "SapReadDbContext", DatabaseType.SqlServer)]
    public partial class PDN1 
    {
        public PDN1()
        {
          this.BaseRef= string.Empty;
          this.LineStatus= string.Empty;
          this.ItemCode= string.Empty;
          this.Dscription= string.Empty;
          this.ShipDate= DateTime.Now;
          this.Currency= string.Empty;
          this.VendorNum= string.Empty;
          this.SerialNum= string.Empty;
          this.WhsCode= string.Empty;
          this.TreeType= string.Empty;
          this.AcctCode= string.Empty;
          this.TaxStatus= string.Empty;
          this.DocDate= DateTime.Now;
          this.UseBaseUn= string.Empty;
          this.SubCatNum= string.Empty;
          this.BaseCard= string.Empty;
          this.InvntSttus= string.Empty;
          this.OcrCode= string.Empty;
          this.Project= string.Empty;
          this.CodeBars= string.Empty;
          this.VatGroup= string.Empty;
          this.UpdInvntry= string.Empty;
          this.BaseAtCard= string.Empty;
          this.SWW= string.Empty;
          this.ObjType= string.Empty;
          this.BlockNum= string.Empty;
          this.ImportLog= string.Empty;
          this.IsAqcuistn= string.Empty;
          this.PoTrgEntry= string.Empty;
          this.DropShip= string.Empty;
          this.Address= string.Empty;
          this.TaxCode= string.Empty;
          this.TaxType= string.Empty;
          this.OrigItem= string.Empty;
          this.BackOrdr= string.Empty;
          this.FreeTxt= string.Empty;
          this.PickStatus= string.Empty;
          this.WtLiable= string.Empty;
          this.DeferrTax= string.Empty;
          this.unitMsr= string.Empty;
          this.CEECFlag= string.Empty;
          this.CountryOrg= string.Empty;
          this.LineType= string.Empty;
          this.TranType= string.Empty;
          this.Text= string.Empty;
          this.ConsumeFCT= string.Empty;
          this.ShipToCode= string.Empty;
          this.ShipToDesc= string.Empty;
          this.BasePrice= string.Empty;
          this.DistribExp= string.Empty;
          this.DescOW= string.Empty;
          this.DetailsOW= string.Empty;
          this.CFOPCode= string.Empty;
          this.CSTCode= string.Empty;
          this.TaxOnly= string.Empty;
          this.WtCalced= string.Empty;
          this.CogsOcrCod= string.Empty;
          this.CogsAcct= string.Empty;
          this.ChgAsmBoMW= string.Empty;
          this.ActDelDate= DateTime.Now;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.PostTax= string.Empty;
          this.Excisable= string.Empty;
          this.CogsOcrCo2= string.Empty;
          this.CogsOcrCo3= string.Empty;
          this.CogsOcrCo4= string.Empty;
          this.CogsOcrCo5= string.Empty;
          this.LnExcised= string.Empty;
          this.unitMsr2= string.Empty;
          this.SpecPrice= string.Empty;
          this.CSTfIPI= string.Empty;
          this.CSTfPIS= string.Empty;
          this.CSTfCOFINS= string.Empty;
          this.ExLineNo= string.Empty;
          this.isSrvCall= string.Empty;
          this.PQTReqDate= DateTime.Now;
          this.LinManClsd= string.Empty;
          this.VatGrpSrc= string.Empty;
          this.NoInvtryMv= string.Empty;
          this.CredOrigin= string.Empty;
          this.UomCode= string.Empty;
          this.UomCode2= string.Empty;
          this.FromWhsCod= string.Empty;
          this.NeedQty= string.Empty;
          this.PartRetire= string.Empty;
          this.EnSetCost= string.Empty;
          this.LineVendor= string.Empty;
          this.DistribIS= string.Empty;
          this.IsByPrdct= string.Empty;
          this.PriceEdit= string.Empty;
          this.LinePoPrss= string.Empty;
          this.FreeChrgBP= string.Empty;
          this.TaxRelev= string.Empty;
          this.LegalText= string.Empty;
          this.ThirdParty= string.Empty;
          this.LicTradNum= string.Empty;
          this.InvQtyOnly= string.Empty;
          this.ShipFromCo= string.Empty;
          this.ShipFromDe= string.Empty;
          this.FisrtBin= string.Empty;
          this.AllocBinC= string.Empty;
          this.ExpType= string.Empty;
          this.ExpUUID= string.Empty;
          this.ExpOpType= string.Empty;
          this.DIOTNat= string.Empty;
          this.MYFtype= string.Empty;
          this.StgDesc= string.Empty;
          this.ItmTaxType= string.Empty;
          this.IsPrscGood= string.Empty;
          this.IsCstmAct= string.Empty;
          this.EncryptIV= string.Empty;
          this.U_WLLY= string.Empty;
          this.U_YYFX= string.Empty;
          this.U_XWJBH= string.Empty;
          this.U_ZWJBH= string.Empty;
          this.U_IG_DW= string.Empty;
          this.U_ZXDH= string.Empty;
          this.U_TYWP= string.Empty;
          this.U_CPH= string.Empty;
          this.U_TYSL= string.Empty;
          this.U_PRX_SID= string.Empty;
          this.U_PDXX= string.Empty;
          this.U_BXSJ= string.Empty;
          this.U_ZS= string.Empty;
          this.U_PSD= string.Empty;
          this.U_RelDoc= string.Empty;
        }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Key]
        public int DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Key]
        public int LineNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TargetType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TrgetEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dscription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ShipDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenQty { get; set; }
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
        public decimal? DiscPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalFrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VendorNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SerialNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SlpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Commission { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TreeType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrossBuyPr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PriceBefDi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Flags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenCreQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseBaseUn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubCatNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenSumSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvntSttus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CodeBars { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PriceAfVAT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Height1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Hght1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Height2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Hght2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Width1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Wdth1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Width2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Wdth2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Length1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Len1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? length2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Len2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Volume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? VolUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Weight1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Wght1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Weight2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Wght2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Factor1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Factor2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Factor3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Factor4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PackQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UpdInvntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseAtCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SWW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSumFrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSumSy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FinncPriod { get; set; }
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
        public string BlockNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ImportLog { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DedVatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DedVatSumF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DedVatSumS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsAqcuistn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DistribSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DstrbSumFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DstrbSumSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrssProfit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrssProfSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrssProfFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VisOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? INMPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PoTrgNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PoTrgEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DropShip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PoLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrigItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BackOrdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeTxt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PickStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PickOty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? PickIdNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TrnsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatAppld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatAppldFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatAppldSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseOpnQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatDscntPr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WtLiable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeferrTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EquVatPer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EquVatSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EquVatSumF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EquVatSumS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineVat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineVatlF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineVatS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string unitMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NumPerMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CEECFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ToStock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ToDiff { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExciseAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxPerUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotInclTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CountryOrg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StckDstSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ReleasQtty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TranType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OwnerCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StockPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ConsumeFCT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LstByDsSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StckINMPr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LstBINMPr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StckDstFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StckDstSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LstByDsFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LstByDsSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StockSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StockSumFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StockSumSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StckSumApp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StckAppFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StckAppSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShipToCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShipToDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StckAppD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StckAppDFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StckAppDSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BasePrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GTotalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GTotalSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DistribExp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DescOW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DetailsOW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GrossBase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatWoDpm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatWoDpmFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatWoDpmSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CFOPCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CSTCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Usage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxOnly { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WtCalced { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? QtyToShip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DelivrdQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrderedQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CogsOcrCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CiOppLineN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CogsAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ChgAsmBoMW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ActDelDate { get; set; }
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
        public decimal? TaxDistSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxDistSFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TaxDistSSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PostTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Excisable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AssblValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RG23APart1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RG23APart2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RG23CPart1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RG23CPart2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CogsOcrCo2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CogsOcrCo3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CogsOcrCo4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CogsOcrCo5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LnExcised { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LocCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StockValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GPTtlBasPr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string unitMsr2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NumPerMsr2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SpecPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CSTfIPI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CSTfPIS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CSTfCOFINS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExLineNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string isSrvCall { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PQTReqQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PQTReqDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PcDocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PcQuantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinManClsd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGrpSrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NoInvtryMv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActBaseEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActBaseLn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActBaseNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenRtnQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AgrNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AgrLnNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CredOrigin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Surpluses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DefBreak { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Shortages { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UomEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UomEntry2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UomCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UomCode2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FromWhsCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NeedQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PartRetire { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RetireQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RetireAPC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RetirAPCFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RetirAPCSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? InvQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenInvQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EnSetCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RetCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Incoterms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TransMod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineVendor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DistribIS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ISDistrb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ISDistrbFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ISDistrbSC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsByPrdct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ItemType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriceEdit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PrntLnNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinePoPrss { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeChrgBP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxRelev { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LegalText { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ThirdParty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LicTradNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvQtyOnly { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UnencReasn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShipFromCo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShipFromDe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FisrtBin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AllocBinC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpUUID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpOpType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DIOTNat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MYFtype { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GPBefDisc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ReturnRsn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ReturnAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StgSeqNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StgEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StgDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmTaxType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SacEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NCMCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? HsnEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OriBAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OriBLinNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OriBDocTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsPrscGood { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsCstmAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_WLLY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_YYFX { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_XWJBH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZWJBH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_IG_DW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_ZDJG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZXDH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_TYWP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_CPH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_TYSL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_SID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? U_CCSJ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PDXX { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_BXSJ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? U_LineID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PSD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_RelDoc { get; set; }
    }
}