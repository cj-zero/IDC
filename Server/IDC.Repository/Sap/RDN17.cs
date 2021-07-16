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
    public partial class RDN17 
    {
        public RDN17()
        {
          this.ObjectType= string.Empty;
          this.ImpDocType= string.Empty;
          this.ImpDocNum= string.Empty;
          this.DateOfReg= DateTime.Now;
          this.CustClrDat= DateTime.Now;
          this.ConcActNum= string.Empty;
          this.AdditNum= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ImpDocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ImpDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateOfReg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CustClrDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ConcActNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AdditNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AddItmDV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? tpVTransp { get; set; }
    }
}