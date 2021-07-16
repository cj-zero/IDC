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
    public partial class ODDT 
    {
        public ODDT()
        {
          this.CardCode= string.Empty;
          this.TrcCode= string.Empty;
          this.TrcName= string.Empty;
          this.DateFrom= DateTime.Now;
          this.DateTo= DateTime.Now;
          this.DataSource= string.Empty;
          this.LastUpdate= DateTime.Now;
          this.WHShaamGrp= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrcCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrcName { get; set; }
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
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LastUpdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WHShaamGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DdctPrcnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MaxSum { get; set; }
    }
}