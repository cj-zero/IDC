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
    public partial class OEFDW 
    {
        public OEFDW()
        {
          this.RunName= string.Empty;
          this.RunDate= DateTime.Now;
          this.Status= string.Empty;
          this.DateFrom= DateTime.Now;
          this.DateTo= DateTime.Now;
          this.ProfType= string.Empty;
          this.BlockC= string.Empty;
          this.BlockD= string.Empty;
          this.BlockE= string.Empty;
          this.BlockH= string.Empty;
          this.BlockG= string.Empty;
          this.BlockI= string.Empty;
          this.FlPurCode= string.Empty;
          this.AccExtern= string.Empty;
          this.ItmFrom= string.Empty;
          this.ItmTo= string.Empty;
          this.ItQryGroup= string.Empty;
          this.RptReason= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RunName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RunDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RunTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Branch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProfType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockH { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BlockI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FlPurCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AccEmploye { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AccExtern { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItmTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ItmGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItQryGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RptReason { get; set; }
    }
}