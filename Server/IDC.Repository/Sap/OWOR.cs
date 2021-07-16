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
    public partial class OWOR 
    {
        public OWOR()
        {
          this.DocNum= 0;
          this.ItemCode= string.Empty;
          this.Status= string.Empty;
          this.Type= string.Empty;
          this.PostDate= DateTime.Now;
          this.DueDate= DateTime.Now;
          this.OriginType= string.Empty;
          this.Comments= string.Empty;
          this.CloseDate= DateTime.Now;
          this.RlsDate= DateTime.Now;
          this.CardCode= string.Empty;
          this.Warehouse= string.Empty;
          this.Uom= string.Empty;
          this.JrnlMemo= string.Empty;
          this.CreateDate= DateTime.Now;
          this.Printed= string.Empty;
          this.OcrCode= string.Empty;
          this.PIndicator= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.SeriesStr= string.Empty;
          this.SubStr= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.Project= string.Empty;
          this.SupplCode= string.Empty;
          this.PickRmrk= string.Empty;
          this.SysCloseDt= DateTime.Now;
          this.CloseVerNm= string.Empty;
          this.StartDate= DateTime.Now;
          this.ObjType= string.Empty;
          this.ProdName= string.Empty;
          this.RouDatCalc= string.Empty;
          this.UpdAlloc= string.Empty;
          this.VersionNum= string.Empty;
          this.DataSource= string.Empty;
          this.SAPPassprt= string.Empty;
          this.U_ZS= string.Empty;
          this.U_XT_CZ= string.Empty;
          this.U_WO_LTDW= string.Empty;
          this.U_BOM_BBH= string.Empty;
          this.U_job_id= string.Empty;
          this.U_SC_LB= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PlannedQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CmpltQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RjctQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OriginAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OriginNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OriginType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CloseDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RlsDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Warehouse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Uom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LineDirty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string JrnlMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TransId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Printed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PIndicator { get; set; }
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
        public short? SeqCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Serial { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeriesStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SupplCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UomEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PickRmrk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SysCloseDt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SysCloseTm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CloseVerNm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProdName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Priority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RouDatCalc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UpdAlloc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CreateTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UpdateTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VersionNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SAPPassprt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_XT_CZ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_WO_LTDW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_BOM_BBH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_job_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_SC_LB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_JYF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_JGF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? U_TZF { get; set; }
    }
}