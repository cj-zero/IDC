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
    public partial class OMIV 
    {
        public OMIV()
        {
          this.Number= 0;
          this.Date= DateTime.Now;
          this.BPCode= string.Empty;
          this.BPName= string.Empty;
          this.Currency= string.Empty;
          this.Cancelled= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int Number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? LastBilled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Paid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CarryForw { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? CurAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? BillAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? OBPaid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OBLstJENum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Predeces { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Successor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Cancelled { get; set; }
    }
}