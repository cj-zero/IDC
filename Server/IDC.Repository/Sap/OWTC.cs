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
    public partial class OWTC 
    {
        public OWTC()
        {
          this.RctType= string.Empty;
          this.Jurisdict= string.Empty;
          this.WtaxType= string.Empty;
          this.DueDate= DateTime.Now;
          this.RefNumber= string.Empty;
          this.PTICode= string.Empty;
          this.Handwrtten= string.Empty;
          this.PIndicator= string.Empty;
          this.PTICodeRef= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RctType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RctAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Jurisdict { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WtaxType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WtAbsEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CerSeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumVatAmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumDocTot { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumBaseAmn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumAccumAm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? SumPercpAm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PTICode { get; set; }
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
        public string PTICodeRef { get; set; }
    }
}