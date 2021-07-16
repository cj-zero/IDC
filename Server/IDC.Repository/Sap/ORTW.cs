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
    public partial class ORTW 
    {
        public ORTW()
        {
          this.WDueDtFrom= DateTime.Now;
          this.WDueDtTo= DateTime.Now;
          this.WImpFile= string.Empty;
          this.WRelDate= DateTime.Now;
          this.WBankAcc1= string.Empty;
          this.WBankAcc2= string.Empty;
          this.WFileForm2= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? WDueDtFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? WDueDtTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WImpFile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WMatching { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WBoletosAu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WBoletosMn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WBoletosNI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? WRelDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WCollDisc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WBankAcc1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WBankAcc2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WFileForm2 { get; set; }
    }
}