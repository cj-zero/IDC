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
    public partial class PRQ9 
    {
        public PRQ9()
        {
          this.TargetBase= string.Empty;
          this.ObjType= string.Empty;
          this.ObjCode= string.Empty;
          this.BsDocDate= DateTime.Now;
          this.BsDueDate= DateTime.Now;
          this.BsCardName= string.Empty;
          this.BsComments= string.Empty;
          this.Posted= string.Empty;
          this.IsGross= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TargetBase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DrawnSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DrawnSumFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DrawnSumSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplDrawn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplDrawnF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ApplDrawnS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BaseDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BsDocDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? BsDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BsCardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BsComments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Posted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Vat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? VatSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Gross { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrossFc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? GrossSc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsGross { get; set; }
    }
}