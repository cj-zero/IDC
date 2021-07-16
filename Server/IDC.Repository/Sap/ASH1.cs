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
    public partial class ASH1 
    {
        public ASH1()
        {
          this.Date= DateTime.Now;
          this.LaborItem= string.Empty;
          this.CostCenter= string.Empty;
          this.FiProject= string.Empty;
          this.GPSData= string.Empty;
          this.FullDay= string.Empty;
          this.Chargeable= string.Empty;
          this.EncryptIV= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LaborItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Workorder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WorAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ServCall { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CostCenter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FiProject { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GPSData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Branch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Break { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NonBillTm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EffectTm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BillableTm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FullDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ProjectID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Subproject { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? StageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Charged { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Chargeable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
    }
}