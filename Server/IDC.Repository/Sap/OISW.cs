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
    public partial class OISW 
    {
        public OISW()
        {
          this.DeclDescr= string.Empty;
          this.DateFrom= DateTime.Now;
          this.DateTo= DateTime.Now;
          this.RunDate= DateTime.Now;
          this.ImpExpInd= string.Empty;
          this.Status= string.Empty;
          this.CompName= string.Empty;
          this.CompDeclID= string.Empty;
          this.CompStreet= string.Empty;
          this.CompCity= string.Empty;
          this.CompZip= string.Empty;
          this.CompCntry= string.Empty;
          this.DeclCntry= string.Empty;
          this.CntPerson= string.Empty;
          this.CntEmail= string.Empty;
          this.CntPhone= string.Empty;
          this.CntFax= string.Empty;
          this.VATRegNo= string.Empty;
          this.VATRegEx= string.Empty;
          this.DeclNum= string.Empty;
          this.DeclStat= string.Empty;
          this.DeclCurr= string.Empty;
          this.ObligLvl= string.Empty;
          this.TaxState= string.Empty;
          this.CustOffc= string.Empty;
          this.CustOffID= string.Empty;
          this.DeclSerNo= string.Empty;
          this.IntCtrlRef= string.Empty;
          this.Addr1_3p= string.Empty;
          this.Addr2_3p= string.Empty;
          this.Addr3_3p= string.Empty;
          this.Addr4_3p= string.Empty;
          this.CntPers_3p= string.Empty;
          this.CntPhon_3p= string.Empty;
          this.CntFax_3p= string.Empty;
          this.FreeTxt1= string.Empty;
          this.FreeTxt2= string.Empty;
          this.FreeTxt3= string.Empty;
          this.FreeTxt4= string.Empty;
          this.FreeTxt5= string.Empty;
          this.ValidKey= string.Empty;
          this.ISDeclOffc= string.Empty;
          this.ReleaseVer= string.Empty;
          this.PosCredVal= string.Empty;
          this.IncPrevDoc= string.Empty;
          this.DeclPeriod= string.Empty;
          this.GroupData= string.Empty;
          this.CstRecSt= string.Empty;
          this.TaxCodeExt= string.Empty;
          this.ExportPath= string.Empty;
          this.SimpProc= string.Empty;
          this.DspNMass= string.Empty;
          this.ExlDocQt= string.Empty;
          this.ExlDocAm= string.Empty;
          this.AddonRun= string.Empty;
          this.GroupTrans= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeclDescr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RunDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ImpExpInd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MsgType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TtlDocVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompDeclID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompStreet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompZip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompCntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeclCntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CntPersID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntPerson { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntFax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VATRegNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VATRegEx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeclNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DeclNoEx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? HeaderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeclStat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DeclDept { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeclCurr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObligLvl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CustOffc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CustOffID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeclSerNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IntCtrlRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Addr1_3p { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Addr2_3p { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Addr3_3p { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Addr4_3p { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntPers_3p { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntPhon_3p { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CntFax_3p { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeTxt1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeTxt2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeTxt3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeTxt4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeTxt5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValidKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ISDeclOffc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReleaseVer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PosCredVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IncPrevDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DeclPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Box1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Box2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CstRecSt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaxCodeExt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExportPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LLEFMAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SimpProc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DspNMass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExlDocQt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocQtLm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExlDocAm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocAmLm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RunTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AddonRun { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseDecl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupTrans { get; set; }
    }
}