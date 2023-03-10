using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDC.Repository.Entities.NsapBone
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("NsapBoneDbContext","NsapBoneReadDbContext")]
    public partial class sale_rin1 
    {
        public sale_rin1()
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
          this.IsAqcuistn= string.Empty;
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
          this.LineType= string.Empty;
          this.TranType= string.Empty;
          this.Text= string.Empty;
          this.ShipToCode= string.Empty;
          this.ShipToDesc= string.Empty;
          this.BasePrice= string.Empty;
          this.DistribExp= string.Empty;
          this.ActDelDate= DateTime.Now;
          this.PostTax= string.Empty;
          this.Excisable= string.Empty;
          this.LnExcised= string.Empty;
          this.isSrvCall= string.Empty;
          this.PQTReqDate= DateTime.Now;
          this.LinManClsd= string.Empty;
          this.NoInvtryMv= string.Empty;
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
          this.U_PRX_VMas= string.Empty;
          this.U_PRX_VNum= string.Empty;
          this.U_PRX_Note= string.Empty;
          this.U_A_CCNo= string.Empty;
          this.U_A_EDATE= string.Empty;
          this.U_A_SECCOD= string.Empty;
          this.U_A_ADDR1= string.Empty;
          this.U_A_ADDR2= string.Empty;
          this.U_A_ADDR3= string.Empty;
          this.U_A_CITY= string.Empty;
          this.U_A_ZIP= string.Empty;
          this.U_A_CTYPE= string.Empty;
          this.U_A_CREFNO= string.Empty;
          this.U_A_ADATE= string.Empty;
          this.U_A_ACODE= string.Empty;
          this.U_A_STATE= string.Empty;
          this.U_A_CAMT= string.Empty;
          this.U_A_PAYT= string.Empty;
          this.U_BNIncTrm= string.Empty;
          this.U_BNTrnMod= string.Empty;
          this.U_PDXX= string.Empty;
          this.U_BXSJ= string.Empty;
          this.U_ZS= string.Empty;
          this.U_XSTCBL= 0;
          this.U_SCTCBL= 0;
          this.U_YFTCBL= 0;
          this.U_YWF= 0;
          this.U_FWF= 0;
        }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public uint sbo_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public uint DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public uint LineNum { get; set; }

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
        public short? SlpCode { get; set; }
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
        public string BlockNum { get; set; }
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
        public decimal? GrssProfit { get; set; }
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
        public decimal? StockPrice { get; set; }
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
        public string DistribExp { get; set; }
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
        public System.DateTime? ActDelDate { get; set; }
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
        public string NoInvtryMv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenRtnQty { get; set; }
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
        public string U_PRX_VMas { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_VNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PRX_Note { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_CCNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_EDATE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_SECCOD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_ADDR1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_ADDR2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_ADDR3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_CITY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_ZIP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_CTYPE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_CREFNO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_ADATE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_ACODE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_STATE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_CAMT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_A_PAYT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_BNIncTrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_BNTrnMod { get; set; }
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
        public decimal U_XSTCBL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal U_SCTCBL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal U_YFTCBL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal U_YWF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal U_FWF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_SHJSDJ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_SHJSJ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_SHTC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_YF { get; set; }
    }
}