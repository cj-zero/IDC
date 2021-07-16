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
    public partial class UDG1 
    {
        public UDG1()
        {
          this.PrintOnAdd= string.Empty;
          this.ExprtOnAdd= string.Empty;
          this.RoundSums= string.Empty;
          this.Remark= string.Empty;
          this.PrintSums= string.Empty;
          this.VndrNum= string.Empty;
          this.PrnDscnt= string.Empty;
          this.EngKBItem= string.Empty;
          this.EngKBCard= string.Empty;
          this.EmailOnAdd= string.Empty;
          this.PDFOnAdd= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Copies { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrintOnAdd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExprtOnAdd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RoundSums { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrintSums { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VndrNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrnDscnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? HandCopies { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EngKBItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EngKBCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EmailOnAdd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PDFOnAdd { get; set; }
    }
}