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
    public partial class ECM2 
    {
        public ECM2()
        {
          this.Code= string.Empty;
          this.ActType= string.Empty;
          this.ActDesc= string.Empty;
          this.ActStatus= string.Empty;
          this.IsRemoved= string.Empty;
          this.ActMessage= string.Empty;
          this.ObjectID= string.Empty;
          this.ReportID= string.Empty;
          this.SrcObjType= string.Empty;
          this.Cancel= string.Empty;
          this.AssignedID= string.Empty;
          this.DocBtch= string.Empty;
          this.GenType= string.Empty;
          this.TestMode= string.Empty;
          this.PeriodType= string.Empty;
          this.DateFrom= DateTime.Now;
          this.DateTo= DateTime.Now;
          this.CreateDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.GUID= string.Empty;
          this.Authority= string.Empty;
          this.CancStatus= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ParentID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsRemoved { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActMessage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ActEnv { get; set; }
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
        public short? Submits { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ReportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SrcObjAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Cancel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AssignedID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocBtch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DocBtchLn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GenType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TestMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PeriodType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PeriodNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Year { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateTo { get; set; }
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
        public int? CreateTS { get; set; }
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
        public int? UpdateTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SchedJobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GUID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Authority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CancStatus { get; set; }
    }
}