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
    public partial class WOR1 
    {
        public WOR1()
        {
          this.ItemCode= string.Empty;
          this.IssueType= string.Empty;
          this.wareHouse= string.Empty;
          this.VisOrder= 0;
          this.WipActCode= string.Empty;
          this.OcrCode= string.Empty;
          this.OcrCode2= string.Empty;
          this.OcrCode3= string.Empty;
          this.OcrCode4= string.Empty;
          this.OcrCode5= string.Empty;
          this.Project= string.Empty;
          this.UomCode= string.Empty;
          this.LineText= string.Empty;
          this.PickStatus= string.Empty;
          this.ResAlloc= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.Status= string.Empty;
          this.U_ZWLKC= string.Empty;
          this.U_ZWLCN= string.Empty;
          this.U_WFKC= string.Empty;
          this.U_MLKC= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PlannedQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? IssuedQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IssueType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string wareHouse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int VisOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WipActCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CompTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OcrCode { get; set; }
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
        public int? LocCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UomEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UomCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ItemType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AdditQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineText { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PickStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PickQty { get; set; }
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
        public decimal? ReleaseQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResAlloc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? StageId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseQtyNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BaseQtyDen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ReqDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? RtCalcProp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZWLKC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ZWLCN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_WFKC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_MLKC { get; set; }
    }
}