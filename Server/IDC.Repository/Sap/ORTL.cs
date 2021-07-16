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
    public partial class ORTL 
    {
        public ORTL()
        {
          this.ResCode= string.Empty;
          this.LocCode= string.Empty;
          this.VersionNum= string.Empty;
          this.PostDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.DocNum= string.Empty;
          this.BaseDocNum= string.Empty;
          this.StgDesc= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DocLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LocCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VersionNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LineTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OpenQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BaseDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StgSeqNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StgEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StgDesc { get; set; }
    }
}