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
    public partial class RDOC 
    {
        public RDOC()
        {
          this.DocName= string.Empty;
          this.Author= string.Empty;
          this.Notes= string.Empty;
          this.CanChange= string.Empty;
          this.PaperSize= string.Empty;
          this.Oreint= string.Empty;
          this.GridType= string.Empty;
          this.ShowGrid= string.Empty;
          this.SnapGrid= string.Empty;
          this.Picture= string.Empty;
          this.TypeCode= string.Empty;
          this.FrgnReport= string.Empty;
          this.CanSort= string.Empty;
          this.LeaderCode= string.Empty;
          this.FollowCode= string.Empty;
          this.SwapOnScrn= string.Empty;
          this.ScreenFont= string.Empty;
          this.SwpInEmail= string.Empty;
          this.EmailFont= string.Empty;
          this.QString= string.Empty;
          this.QType= string.Empty;
          this.ExtName= string.Empty;
          this.ExtOnErr= string.Empty;
          this.AlgnFooter= string.Empty;
          this.TimeFormat= string.Empty;
          this.DateFormat= string.Empty;
          this.DateSep= string.Empty;
          this.DecSep= string.Empty;
          this.ThousSep= string.Empty;
          this.Printer= string.Empty;
          this.GbiSupport= string.Empty;
          this.Use1stPrtr= string.Empty;
          this.Prtr1st= string.Empty;
          this.Shading= string.Empty;
          this.Category= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.Status= string.Empty;
          this.B1Version= string.Empty;
          this.CRVersion= string.Empty;
          this.Local= string.Empty;
          this.UseSysPref= string.Empty;
          this.ForMobile= string.Empty;
          this.TypeDetail= string.Empty;
          this.IsIMCE= string.Empty;
          this.CsUrl= string.Empty;
          this.RptHash= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Author { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Notes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LMargin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RMargin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TMargin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BMargin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CanChange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PaperSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Oreint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GridSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GridType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowGrid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SnapGrid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Picture { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnReport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CanSort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LeaderCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FollowCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SwapOnScrn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ScreenFont { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ScrFOffset { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SwpInEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmailFont { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? EmFOffset { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QString { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string QType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Language { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RobjCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtOnErr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? NumRepArs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AlgnFooter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TimeFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DateFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DateSep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DecSep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ThousSep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Printer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumLayPage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumCopy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GbiSupport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Use1stPrtr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Prtr1st { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Shading { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] Template { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Category { get; set; }
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
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string B1Version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CRVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Local { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseSysPref { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ForMobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TypeDetail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsIMCE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CsUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RptHash { get; set; }
    }
}