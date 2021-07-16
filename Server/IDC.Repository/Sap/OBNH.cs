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
    public partial class OBNH 
    {
        public OBNH()
        {
          this.ActKey= 0;
          this.BSNum= 0;
          this.BSDate= DateTime.Now;
          this.Status= string.Empty;
          this.Imported= string.Empty;
          this.Currency= string.Empty;
          this.FileCRC= string.Empty;
          this.StmtGuid= string.Empty;
          this.BSFileNum= string.Empty;
          this.OrigBSDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int ActKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int BSNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime BSDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Imported { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StrtBlncF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EndBlncF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? StrtBlncL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? EndBlncL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FileCRC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StmtGuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BSFileNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PeriodAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DfltBPL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? OrigBSDate { get; set; }
    }
}