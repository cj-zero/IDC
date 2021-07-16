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
    public partial class BOT1 
    {
        public BOT1()
        {
          this.DueDate= DateTime.Now;
          this.BPBankCtr= string.Empty;
          this.BPBankCod= string.Empty;
          this.BPBankAct= string.Empty;
          this.BPBankBrnc= string.Empty;
          this.EnBPBnkAct= string.Empty;
          this.EncryptIV= string.Empty;
          this.DPPStatus= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPBankCtr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPBankCod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPBankAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BPBankBrnc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExReconNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BOEAbs { get; set; }
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
        public string EnBPBnkAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EncryptIV { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DPPStatus { get; set; }
    }
}