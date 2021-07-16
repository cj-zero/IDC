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
    public partial class RTW2 
    {
        public RTW2()
        {
          this.StampDate= DateTime.Now;
          this.RetFile= string.Empty;
          this.Format= string.Empty;
          this.BankCode= string.Empty;
          this.Account= string.Empty;
          this.RunType= string.Empty;
          this.ImCardName= string.Empty;
          this.PostDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SequenceNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StampDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RetFile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Format { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Account { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RunType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RunRecords { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ImCardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PostDate { get; set; }
    }
}