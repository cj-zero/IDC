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
    public partial class OSLD 
    {
        public OSLD()
        {
          this.ObjType= string.Empty;
          this.DocEntry= 0;
          this.DocLineNum= 0;
          this.SchdLine= 0;
          this.ItemCode= string.Empty;
          this.WhsCode= string.Empty;
          this.CfmDate= DateTime.Now;
          this.FixedCfm= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int DocLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int SchdLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CfmDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CfmQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FixedCfm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ReqQty { get; set; }
    }
}