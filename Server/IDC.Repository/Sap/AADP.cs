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
    public partial class AADP 
    {
        public AADP()
        {
          this.PrnCompany= string.Empty;
          this.MnhlNote= string.Empty;
          this.WordPath= string.Empty;
          this.BitmapPath= string.Empty;
          this.PrintMeta= string.Empty;
          this.PrintRcpt= string.Empty;
          this.ShortRcpt= string.Empty;
          this.ExportCode= string.Empty;
          this.AttachPath= string.Empty;
          this.DraftNote= string.Empty;
          this.ExtPath= string.Empty;
          this.DmePath= string.Empty;
          this.GBIPath= string.Empty;
          this.LogoFile= string.Empty;
          this.B1Server= string.Empty;
          this.IsTrustSrv= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.DefirExpP= string.Empty;
          this.DefirDemop= string.Empty;
          this.PrintPDF= string.Empty;
          this.PrtCancel= string.Empty;
          this.PrtUseSys= string.Empty;
          this.RptList= string.Empty;
          this.PreAttach= string.Empty;
          this.ExportPDF= string.Empty;
          this.AttachPDF= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ObjList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? MaxLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TopMrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? BtmMrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LftMrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RgtMrgn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrnCompany { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MnhlNote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? MaxWordLin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? V_Compress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WordPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BitmapPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrintMeta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrintRcpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShortRcpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExportCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttachPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DraftNote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DmePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SNType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GBIPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LogoFile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] LogoImage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string B1Server { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsTrustSrv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? SnapShotId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DefirExpP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DefirDemop { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrintPDF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrtCancel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrtUseSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RptList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PreAttach { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExportPDF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttachPDF { get; set; }
    }
}