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
    public partial class store_oitm
    {
        public store_oitm()
        {
          this.ItemName= string.Empty;
          this.FrgnName= string.Empty;
          this.VatGourpSa= string.Empty;
          this.CodeBars= string.Empty;
          this.VATLiable= string.Empty;
          this.PrchseItem= string.Empty;
          this.SellItem= string.Empty;
          this.InvntItem= string.Empty;
          this.IncomeAcct= string.Empty;
          this.ExmptIncom= string.Empty;
          this.DfltWH= string.Empty;
          this.CardCode= string.Empty;
          this.SuppCatNum= string.Empty;
          this.BuyUnitMsr= string.Empty;
          this.LstEvlDate= DateTime.Now;
          this.Canceled= string.Empty;
          this.WholSlsTax= string.Empty;
          this.RetilrTax= string.Empty;
          this.TrackSales= string.Empty;
          this.SalUnitMsr= string.Empty;
          this.EvalSystem= string.Empty;
          this.FREE= string.Empty;
          this.PicturName= string.Empty;
          this.Transfered= string.Empty;
          this.BlncTrnsfr= string.Empty;
          this.UserText= string.Empty;
          this.SerialNum= string.Empty;
          this.TreeType= string.Empty;
          this.LastPurCur= string.Empty;
          this.LastPurDat= DateTime.Now;
          this.ExitCur= string.Empty;
          this.ExitWH= string.Empty;
          this.AssetItem= string.Empty;
          this.WasCounted= string.Empty;
          this.ManSerNum= string.Empty;
          this.FixCurrCms= string.Empty;
          this.LstSalDate= DateTime.Now;
          this.QryGroup1= string.Empty;
          this.QryGroup2= string.Empty;
          this.QryGroup3= string.Empty;
          this.QryGroup4= string.Empty;
          this.QryGroup5= string.Empty;
          this.QryGroup6= string.Empty;
          this.QryGroup7= string.Empty;
          this.QryGroup8= string.Empty;
          this.QryGroup9= string.Empty;
          this.QryGroup10= string.Empty;
          this.QryGroup11= string.Empty;
          this.QryGroup12= string.Empty;
          this.QryGroup13= string.Empty;
          this.QryGroup14= string.Empty;
          this.QryGroup15= string.Empty;
          this.QryGroup16= string.Empty;
          this.QryGroup17= string.Empty;
          this.QryGroup18= string.Empty;
          this.QryGroup19= string.Empty;
          this.QryGroup20= string.Empty;
          this.QryGroup21= string.Empty;
          this.QryGroup22= string.Empty;
          this.QryGroup23= string.Empty;
          this.QryGroup24= string.Empty;
          this.QryGroup25= string.Empty;
          this.QryGroup26= string.Empty;
          this.QryGroup27= string.Empty;
          this.QryGroup28= string.Empty;
          this.QryGroup29= string.Empty;
          this.QryGroup30= string.Empty;
          this.QryGroup31= string.Empty;
          this.QryGroup32= string.Empty;
          this.QryGroup33= string.Empty;
          this.QryGroup34= string.Empty;
          this.QryGroup35= string.Empty;
          this.QryGroup36= string.Empty;
          this.QryGroup37= string.Empty;
          this.QryGroup38= string.Empty;
          this.QryGroup39= string.Empty;
          this.QryGroup40= string.Empty;
          this.QryGroup41= string.Empty;
          this.QryGroup42= string.Empty;
          this.QryGroup43= string.Empty;
          this.QryGroup44= string.Empty;
          this.QryGroup45= string.Empty;
          this.QryGroup46= string.Empty;
          this.QryGroup47= string.Empty;
          this.QryGroup48= string.Empty;
          this.QryGroup49= string.Empty;
          this.QryGroup50= string.Empty;
          this.QryGroup51= string.Empty;
          this.QryGroup52= string.Empty;
          this.QryGroup53= string.Empty;
          this.QryGroup54= string.Empty;
          this.QryGroup55= string.Empty;
          this.QryGroup56= string.Empty;
          this.QryGroup57= string.Empty;
          this.QryGroup58= string.Empty;
          this.QryGroup59= string.Empty;
          this.QryGroup60= string.Empty;
          this.QryGroup61= string.Empty;
          this.QryGroup62= string.Empty;
          this.QryGroup63= string.Empty;
          this.QryGroup64= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.ExportCode= string.Empty;
          this.SalFormula= string.Empty;
          this.PurFormula= string.Empty;
          this.VatGroupPu= string.Empty;
          this.PurPackMsr= string.Empty;
          this.SalPackMsr= string.Empty;
          this.ManBtchNum= string.Empty;
          this.ManOutOnly= string.Empty;
          this.validFor= string.Empty;
          this.validFrom= DateTime.Now;
          this.validTo= DateTime.Now;
          this.frozenFor= string.Empty;
          this.frozenFrom= DateTime.Now;
          this.frozenTo= DateTime.Now;
          this.BlockOut= string.Empty;
          this.ValidComm= string.Empty;
          this.FrozenComm= string.Empty;
          this.ObjType= string.Empty;
          this.SWW= string.Empty;
          this.Deleted= string.Empty;
          this.ExpensAcct= string.Empty;
          this.FrgnInAcct= string.Empty;
          this.GLMethod= string.Empty;
          this.ECInAcct= string.Empty;
          this.FrgnExpAcc= string.Empty;
          this.ECExpAcc= string.Empty;
          this.TaxType= string.Empty;
          this.ByWh= string.Empty;
          this.WTLiable= string.Empty;
          this.ItemType= string.Empty;
          this.WarrntTmpl= string.Empty;
          this.BaseUnit= string.Empty;
          this.Phantom= string.Empty;
          this.IssueMthd= string.Empty;
          this.FREE1= string.Empty;
          this.MngMethod= string.Empty;
          this.InvntryUom= string.Empty;
          this.PlaningSys= string.Empty;
          this.PrcrmntMtd= string.Empty;
          this.IndirctTax= string.Empty;
          this.TaxCodeAR= string.Empty;
          this.TaxCodeAP= string.Empty;
          this.MatType= string.Empty;
          this.ProductSrc= string.Empty;
          this.ItemClass= string.Empty;
          this.Excisable= string.Empty;
          this.NotifyASN= string.Empty;
          this.ProAssNum= string.Empty;
          this.Spec= string.Empty;
          this.TaxCtg= string.Empty;
          this.U_USER_ID= string.Empty;
          this.U_job_id= string.Empty;
          this.U_ItemCode= string.Empty;
          this.U_TDS= string.Empty;
          this.U_DY= string.Empty;
          this.U_DL= string.Empty;
          this.U_DLDW= string.Empty;
          this.U_FZ_A101= string.Empty;
          this.U_ZZ_A101= string.Empty;
          this.U_JD_A101= string.Empty;
          this.U_GYSXH_A101= string.Empty;
          this.U_PP_A101= string.Empty;
          this.U_FZ_A102= string.Empty;
          this.U_RL_A102= string.Empty;
          this.U_JSCS_A102= string.Empty;
          this.U_GYSXH_A102= string.Empty;
          this.U_ZXBZ_A102= string.Empty;
          this.U_PP_A102= string.Empty;
          this.U_GL_A104= string.Empty;
          this.U_ZZ_A104= string.Empty;
          this.U_GGCS_A104= string.Empty;
          this.U_CPXH_A105= string.Empty;
          this.U_ZZ_A105= string.Empty;
          this.U_PP_A105= string.Empty;
          this.U_TDS_CA= string.Empty;
          this.U_XL_A105= string.Empty;
          this.U_TDS_CC= string.Empty;
          this.U_DY_CC= string.Empty;
          this.U_DL_CC= string.Empty;
          this.U_JJ_CC= string.Empty;
          this.U_LX_A107= string.Empty;
          this.U_DL_A107= string.Empty;
          this.U_DY_A107= string.Empty;
          this.U_GYCZ_A107= string.Empty;
          this.U_TZBB_A107= string.Empty;
          this.U_DY_A108= string.Empty;
          this.U_RL_A108= string.Empty;
          this.U_GGCS_A108= string.Empty;
          this.U_GYSGG_A108= string.Empty;
          this.U_DGL_A108= string.Empty;
          this.U_GGCS_A109= string.Empty;
          this.U_GYS_A109= string.Empty;
          this.U_WLXH_A110= string.Empty;
          this.U_GNMS_A110= string.Empty;
          this.U_ZXBZ_A110= string.Empty;
          this.U_PP_A110= string.Empty;
          this.U_WLXH_A111= string.Empty;
          this.U_GNMS_A111= string.Empty;
          this.U_FZ_A111= string.Empty;
          this.U_ZXBZ_A111= string.Empty;
          this.U_PP_A111= string.Empty;
          this.U_WLXH_A112= string.Empty;
          this.U_GGCS_A112= string.Empty;
          this.U_PP_A112= string.Empty;
          this.U_XL= string.Empty;
          this.U_TSYQ= string.Empty;
          this.U_JJ= string.Empty;
          this.U_DZ= string.Empty;
          this.U_FZ_A110= string.Empty;
          this.U_XL_CJ= string.Empty;
          this.U_DY_CJ= string.Empty;
          this.U_DL_CJ= string.Empty;
          this.U_TD_CJ= string.Empty;
          this.U_TDS_CE= string.Empty;
          this.U_JDFZ_A103= string.Empty;
          this.U_ZZ_A103= string.Empty;
          this.UL_XL= string.Empty;
          this.U_FDY= string.Empty;
        }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int sbo_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItmsGrpCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CstGrpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGourpSa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CodeBars { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VATLiable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrchseItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SellItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvntItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OnHand { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IsCommited { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OnOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncomeAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExmptIncom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DfltWH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SuppCatNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BuyUnitMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NumInBuy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ReorderQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LstEvlPric { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LstEvlDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CustomPer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Canceled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MnufctTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WholSlsTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RetilrTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SpcialDisc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DscountCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrackSales { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SalUnitMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NumInSale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Consig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? QueryGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Counted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenBlnc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EvalSystem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FREE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PicturName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlncTrnsfr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserText { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SerialNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CommisPcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CommisSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CommisGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TreeType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TreeQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LastPurPrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LastPurCur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LastPurDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExitCur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ExitPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExitWH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AssetItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WasCounted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManSerNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SHeight1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SHght1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SHeight2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SHght2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SWidth1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SWdth1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SWidth2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SWdth2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SLength1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SLen1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Slength2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SLen2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SVolume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SVolUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SWeight1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SWght1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SWeight2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SWght2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BHeight1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BHght1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BHeight2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BHght2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BWidth1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BWdth1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BWidth2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BWdth2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BLength1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BLen1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Blength2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BLen2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BVolume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BVolUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BWeight1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BWght1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BWeight2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BWght2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FixCurrCms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FirmCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LstSalDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QryGroup64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExportCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SalFactor1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SalFactor2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SalFactor3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SalFactor4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PurFactor1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PurFactor2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PurFactor3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PurFactor4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SalFormula { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurFormula { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VatGroupPu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AvgPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PurPackMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PurPackUn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SalPackMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SalPackUn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManBtchNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ManOutOnly { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string validFor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? validFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? validTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string frozenFor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? frozenFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? frozenTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockOut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValidComm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrozenComm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SWW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Deleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExpensAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnInAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ShipType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GLMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ECInAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnExpAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ECExpAcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ByWh { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WTLiable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WarrntTmpl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StockValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Phantom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IssueMthd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FREE1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PricingPrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MngMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ReorderPnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string InvntryUom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PlaningSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrcrmntMtd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? OrdrIntrvl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OrdrMulti { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinOrdrQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LeadTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IndirctTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCodeAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCodeAP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ServiceGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MatType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MatGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProductSrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ServiceCtg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemClass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Excisable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ChapterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NotifyASN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProAssNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AssblValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Spec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCtg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ToleranDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_USER_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_job_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_JGF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? U_WLBM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_TDS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_DY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_DL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_JYF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_DLDW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_FZ_A101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZZ_A101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_JD_A101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_GYSXH_A101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PP_A101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_FZ_A102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_RL_A102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_JSCS_A102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_GYSXH_A102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZXBZ_A102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PP_A102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_GL_A104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZZ_A104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_GGCS_A104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_CPXH_A105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZZ_A105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PP_A105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_TDS_CA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_XL_A105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_TDS_CC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_DY_CC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_DL_CC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_JJ_CC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_LX_A107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_DL_A107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_DY_A107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_GYCZ_A107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_TZBB_A107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_DY_A108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_RL_A108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_GGCS_A108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_GYSGG_A108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_DGL_A108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_GGCS_A109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_GYS_A109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_WLXH_A110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_GNMS_A110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZXBZ_A110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PP_A110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_WLXH_A111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_GNMS_A111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_FZ_A111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZXBZ_A111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PP_A111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_WLXH_A112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_GGCS_A112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_PP_A112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? U_US { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? U_FS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_XL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_TSYQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_JJ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_DZ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_YFCB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? U_JGZQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_U_GS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_GS_DJ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_JGF1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_FZ_A110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_XL_CJ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_DY_CJ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_DL_CJ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_TD_CJ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_TDS_CE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_JDFZ_A103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZZ_A103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UL_XL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_FDY { get; set; }
    }
}