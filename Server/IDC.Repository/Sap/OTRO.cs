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
    public partial class OTRO 
    {
        public OTRO()
        {
          this.NextNum= 0;
          this.PostDate= DateTime.Now;
          this.EDocGenTyp= string.Empty;
          this.TranspNum= string.Empty;
          this.Expiration= DateTime.Now;
          this.Vehicle= string.Empty;
          this.TrailerID= string.Empty;
          this.Carrier= string.Empty;
          this.IssueGate= 0;
          this.UpdateDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.CANCELED= string.Empty;
          this.WhsCode= string.Empty;
          this.COTcode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int NextNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EDocGenTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EDocExpFrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TranspNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Expiration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Vehicle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrailerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Carrier { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int IssueGate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
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
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UpdateTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CANCELED { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Weight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? WghtUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalLC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string COTcode { get; set; }
    }
}