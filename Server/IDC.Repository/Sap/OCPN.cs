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
    public partial class OCPN 
    {
        public OCPN()
        {
          this.Name= string.Empty;
          this.Type= string.Empty;
          this.TargetGrp= string.Empty;
          this.Status= string.Empty;
          this.StartDate= DateTime.Now;
          this.FinishDate= DateTime.Now;
          this.Remarks= string.Empty;
          this.WizardGen= string.Empty;
          this.Attachment= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.DataSource= string.Empty;
          this.Transfered= string.Empty;
          this.Url= string.Empty;
          this.TmplPath= string.Empty;
          this.TargetType= string.Empty;
          this.ExeOption= string.Empty;
          this.Executed= string.Empty;
          this.VersionNum= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TargetGrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? FinishDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WizardGen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.Byte[] Template { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attachment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogIns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DataSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Transfered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Instance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TmplPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TargetType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExeOption { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Executed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VersionNum { get; set; }
    }
}