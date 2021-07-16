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
    public partial class PQW1 
    {
        public PQW1()
        {
          this.ItemCode= string.Empty;
          this.Dscription= string.Empty;
          this.PQTReqDate= DateTime.Now;
          this.BuyUnitMsr= string.Empty;
          this.FreeTxt= string.Empty;
          this.PQTGrpHW= string.Empty;
          this.ValidUntil= DateTime.Now;
          this.WhsCode= string.Empty;
          this.ReqName= string.Empty;
          this.PRLineStat= string.Empty;
          this.DistriRule= string.Empty;
          this.Project= string.Empty;
          this.VendMfrNum= string.Empty;
          this.PriceMode= string.Empty;
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
        public string Dscription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PQTReqDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PQTReqQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BuyUnitMsr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeTxt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PQTGrpNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PQTGrpSer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PQTGrpHW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValidUntil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PQTSeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PRAbsEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReqName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PRLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PRLineStat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DistriRule { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VendMfrNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ShipType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ItmPerUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PriceMode { get; set; }
    }
}