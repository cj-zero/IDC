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
    public partial class DAR2 
    {
        public DAR2()
        {
          this.Approve= string.Empty;
          this.CardCode= string.Empty;
          this.RefDate= DateTime.Now;
          this.DueDate= DateTime.Now;
          this.TaxDate= DateTime.Now;
          this.Action= string.Empty;
          this.Remarks= string.Empty;
          this.KeySeg1= string.Empty;
          this.KeySeg2= string.Empty;
          this.KeySeg3= string.Empty;
          this.KeySeg4= string.Empty;
          this.KeySeg5= string.Empty;
          this.KeySeg6= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Approve { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RefDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Total { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KeySeg6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? ClusterId { get; set; }
    }
}