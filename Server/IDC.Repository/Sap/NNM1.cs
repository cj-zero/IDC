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
    public partial class NNM1 
    {
        public NNM1()
        {
          this.ObjectCode= string.Empty;
          this.SeriesName= string.Empty;
          this.BeginStr= string.Empty;
          this.EndStr= string.Empty;
          this.Remark= string.Empty;
          this.Locked= string.Empty;
          this.YearTransf= string.Empty;
          this.Indicator= string.Empty;
          this.Template= string.Empty;
          this.FolioPref= string.Empty;
          this.DocSubType= string.Empty;
          this.IsDigSerie= string.Empty;
          this.SeriesType= string.Empty;
          this.IsManual= string.Empty;
          this.IsForCncl= string.Empty;
          this.AtDocType= string.Empty;
          this.IsElAuth= string.Empty;
          this.CoAccount= string.Empty;
          this.GenPassprt= string.Empty;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeriesName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InitialNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NextNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LastNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BeginStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EndStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GroupCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string YearTransf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Indicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Template { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FolioPref { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NextFolio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocSubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DefESeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsDigSerie { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeriesType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsManual { get; set; }
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
        public string IsForCncl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AtDocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsElAuth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CoAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GenPassprt { get; set; }
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
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? logInstanc { get; set; }
    }
}