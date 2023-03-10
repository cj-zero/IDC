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
    public partial class AISC 
    {
        public AISC()
        {
          this.DocNum= 0;
          this.PostDate= DateTime.Now;
          this.DocDate= DateTime.Now;
          this.DocStatus= string.Empty;
          this.Revised= string.Empty;
          this.OrgRefNo= string.Empty;
          this.OrgDocDate= DateTime.Now;
          this.Comments= string.Empty;
          this.ObjType= string.Empty;
          this.SrcLocName= string.Empty;
          this.SrcGSTIN= string.Empty;
          this.TarLocName= string.Empty;
          this.TarGSTIN= string.Empty;
          this.DataSource= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.JrnlMemo= string.Empty;
          this.Handwrtten= string.Empty;
          this.PIndicator= string.Empty;
          this.BPLName= string.Empty;
          this.VATRegNum= string.Empty;
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
        public System.DateTime? PostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Revised { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrgRefNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OrgRefEty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? OrgDocDate { get; set; }
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
        public string Comments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SrcLoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcLocName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcGSTIN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TarLoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TarLocName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TarGSTIN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ISDEntry { get; set; }
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
        public System.DateTime? CreateDate { get; set; }
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
        public string JrnlMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Handwrtten { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PIndicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? BPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPLName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VATRegNum { get; set; }
    }
}