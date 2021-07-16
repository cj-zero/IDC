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
    public partial class OUDO 
    {
        public OUDO()
        {
          this.Name= string.Empty;
          this.TableName= string.Empty;
          this.LogTable= string.Empty;
          this.TYPE= string.Empty;
          this.MngSeries= string.Empty;
          this.CanDelete= string.Empty;
          this.CanClose= string.Empty;
          this.CanCancel= string.Empty;
          this.ExtName= string.Empty;
          this.CanFind= string.Empty;
          this.CanYrTrnsf= string.Empty;
          this.CanDefForm= string.Empty;
          this.CanLog= string.Empty;
          this.OvrWrtDll= string.Empty;
          this.UIDFormat= string.Empty;
          this.CanArchive= string.Empty;
          this.MenuItem= string.Empty;
          this.MenuCapt= string.Empty;
          this.CanNewForm= string.Empty;
          this.IsRebuild= string.Empty;
          this.NewFormSrf= string.Empty;
          this.MenuUid= string.Empty;
          this.LstUpdDate= DateTime.Now;
          this.CanApprove= string.Empty;
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
        public string TableName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LogTable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TYPE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MngSeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CanDelete { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CanClose { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CanCancel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CanFind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CanYrTrnsf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CanDefForm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CanLog { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OvrWrtDll { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UIDFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CanArchive { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MenuItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MenuCapt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FatherMenu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CanNewForm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsRebuild { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NewFormSrf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MenuUid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LstUpdDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LstUpdTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CanApprove { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TemplateID { get; set; }
    }
}