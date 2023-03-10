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
    public partial class OEJB 
    {
        public OEJB()
        {
          this.WizardName= string.Empty;
          this.FromDate= DateTime.Now;
          this.ToDate= DateTime.Now;
          this.PFromDate= DateTime.Now;
          this.PToDate= DateTime.Now;
          this.DateOfRun= DateTime.Now;
          this.Status= string.Empty;
          this.ActYearCl= string.Empty;
          this.OverwrFinS= string.Empty;
          this.Reference= string.Empty;
          this.PayRef= string.Empty;
          this.CRegNumber= string.Empty;
          this.LFBSheetD= string.Empty;
          this.LFBSheetPr= string.Empty;
          this.RegNum= string.Empty;
          this.CmpanyName= string.Empty;
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
        public System.DateTime? FromDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PFromDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateOfRun { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActYearCl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FormFinSt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EBSTmpl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? EPaLTmpl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OverwrFinS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Reference { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? HBCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PayRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SndrRole { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CRegNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LFBSheetD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LFBSheetPr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RegNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CmpanyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] XMLFile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? TimeOfRun { get; set; }
    }
}