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
    public partial class OCYC 
    {
        public OCYC()
        {
          this.Name= string.Empty;
          this.Frequency= string.Empty;
          this.NextDate= DateTime.Now;
          this.Type= string.Empty;
          this.SubOption= string.Empty;
          this.EndType= string.Empty;
          this.SeEndDat= DateTime.Now;
          this.Sunday= string.Empty;
          this.Monday= string.Empty;
          this.Tuesday= string.Empty;
          this.Wednesday= string.Empty;
          this.Thursday= string.Empty;
          this.Friday= string.Empty;
          this.Saturday= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Frequency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Day { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Hour { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? NextDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SubOption { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Interval { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EndType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MaxOccur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? SeEndDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Sunday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Monday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Tuesday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Wednesday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Thursday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Friday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Saturday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DayInMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Week { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DayOfWeek { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Month { get; set; }
    }
}