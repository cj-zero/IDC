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
    public partial class NFN1 
    {
        public NFN1()
        {
          this.SeqName= string.Empty;
          this.SeriesStr= string.Empty;
          this.SubStr= string.Empty;
          this.Remark= string.Empty;
          this.Locked= string.Empty;
          this.YearTransf= string.Empty;
          this.Indicator= string.Empty;
          this.Template= string.Empty;
          this.Prefix= string.Empty;
          this.Suffix= string.Empty;
          this.Model= string.Empty;
          this.BPLId= 0;
          this.IsDigital= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeqName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? InitialNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NextNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LastNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SeriesStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubStr { get; set; }
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
        public string Prefix { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Suffix { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Model { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int BPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsDigital { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EnvTypeNFe { get; set; }
    }
}