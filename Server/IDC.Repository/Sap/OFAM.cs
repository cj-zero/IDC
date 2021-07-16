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
    public partial class OFAM 
    {
        public OFAM()
        {
          this.WizardName= string.Empty;
          this.CreateDate= DateTime.Now;
          this.AcctDtn= string.Empty;
          this.DprArea= string.Empty;
          this.DprType= string.Empty;
          this.AssetClass= string.Empty;
          this.AssetNum= string.Empty;
          this.AssetItem= string.Empty;
          this.UpdExstItm= string.Empty;
          this.Status= string.Empty;
          this.Remarks= string.Empty;
          this.FiscalYear= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WizardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AcctDtn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DprArea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DprType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AssetClass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AssetNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AssetItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UpdExstItm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FiscalYear { get; set; }
    }
}