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
    public partial class APJ1 
    {
        public APJ1()
        {
          this.StepName= string.Empty;
          this.StepInfo= string.Empty;
          this.StepNotes= string.Empty;
          this.StepLink= string.Empty;
          this.StartDate= DateTime.Now;
          this.EndDate= DateTime.Now;
          this.IsComplete= string.Empty;
          this.Owner= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Father { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VisOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StepName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StepInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StepNotes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StepLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsComplete { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Duration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PlanTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? TotalPTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? QueryID { get; set; }
    }
}