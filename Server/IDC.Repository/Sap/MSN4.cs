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
    public partial class MSN4 
    {
        public MSN4()
        {
          this.Selected= string.Empty;
          this.TmpForMrp= string.Empty;
          this.WorDueDate= DateTime.Now;
          this.DsmDueDate= DateTime.Now;
          this.NorDueDate= DateTime.Now;
          this.prcrmntMtd= string.Empty;
          this.CompoWH= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Selected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TmpForMrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? WorDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DsmDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? NorDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Interval { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Multiple { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? MinORdrQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LeadTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string prcrmntMtd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ToleranDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CompoWH { get; set; }
    }
}