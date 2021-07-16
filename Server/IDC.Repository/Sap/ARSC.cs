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
    public partial class ARSC 
    {
        public ARSC()
        {
          this.VisResCode= string.Empty;
          this.CodeBars= string.Empty;
          this.ResName= string.Empty;
          this.FrgnName= string.Empty;
          this.ResType= string.Empty;
          this.UnitOfMsr= string.Empty;
          this.PrchseRes= string.Empty;
          this.SellRes= string.Empty;
          this.ProdRes= string.Empty;
          this.CardCode= string.Empty;
          this.NoDiscount= string.Empty;
          this.IssueMthd= string.Empty;
          this.validFor= string.Empty;
          this.validFrom= DateTime.Now;
          this.validTo= DateTime.Now;
          this.frozenFor= string.Empty;
          this.frozenFrom= DateTime.Now;
          this.frozenTo= DateTime.Now;
          this.DfltWH= string.Empty;
          this.PicturName= string.Empty;
          this.UserText= string.Empty;
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
          this.DataSource= string.Empty;
          this.ValidComm= string.Empty;
          this.FrozenComm= string.Empty;
          this.ObjType= string.Empty;
          this.Deleted= string.Empty;
          this.Attachment= string.Empty;
          this.LastPurCur= string.Empty;
          this.LastPurDat= DateTime.Now;
          this.LstEvlDate= DateTime.Now;
          this.ResAlloc= string.Empty;
          this.LinkItm= string.Empty;
          this.RelCap1= string.Empty;
          this.RelCap2= string.Empty;
          this.RelCap3= string.Empty;
          this.RelCap4= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VisResCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CodeBars { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ResGrpCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UnitOfMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrchseRes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SellRes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProdRes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NoDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IssueMthd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StdCost1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StdCost2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StdCost3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StdCost4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StdCost5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StdCost6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StdCost7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StdCost8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StdCost9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StdCost10 { get; set; }
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
        public string DfltWH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? QueryGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PicturName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserText { get; set; }
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
        public string DataSource { get; set; }
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
        public string Deleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attachment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
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
        public int? NumResUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TimeResUn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResAlloc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LinkItm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RelCap1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RelCap2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RelCap3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RelCap4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
    }
}