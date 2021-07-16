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
    public partial class ORCJ 
    {
        public ORCJ()
        {
          this.ResCode= string.Empty;
          this.WhsCode= string.Empty;
          this.CapDate= DateTime.Now;
          this.CapType= string.Empty;
          this.MemoSrc= string.Empty;
          this.Memo= string.Empty;
          this.MemoSrcSng= string.Empty;
          this.MemoSng= string.Empty;
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
        public string WhsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CapDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CapType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Capacity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SrcObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SrcAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SrcLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseObjTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ActionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OwnObjTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OwnAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OwnLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RevdObjTyp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RevdAbsEnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RevdLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MemoSrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Memo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SngRunCap { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MemoSrcSng { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MemoSng { get; set; }
    }
}