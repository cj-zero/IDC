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
    public partial class PWZ5 
    {
        public PWZ5()
        {
          this.CardCode= string.Empty;
          this.CardName= string.Empty;
          this.PostDate= DateTime.Now;
          this.ErrDisc= string.Empty;
          this.WriteErr= string.Empty;
          this.Currency= string.Empty;
          this.LineType= string.Empty;
          this.ValDate= DateTime.Now;
          this.DPPStatus= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ErrDisc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WriteErr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? invNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LineType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DueBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DueBalFC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DueBalSys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ValDate { get; set; }
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
        public string DPPStatus { get; set; }
    }
}