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
    public partial class OALT 
    {
        public OALT()
        {
          this.Name= string.Empty;
          this.Type= string.Empty;
          this.Priority= string.Empty;
          this.Active= string.Empty;
          this.ParamData= string.Empty;
          this.Params= string.Empty;
          this.DocsData= string.Empty;
          this.Docs= string.Empty;
          this.UserText= string.Empty;
          this.FrqncyType= string.Empty;
          this.LastDate= DateTime.Now;
          this.NextDate= DateTime.Now;
          this.History= string.Empty;
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
        public string Priority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumOfParam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ParamData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Params { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumOfDocs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocsData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Docs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UserText { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? QueryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrqncyType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FrqncyIntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ExecDaY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExecTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LastDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? LastTIME { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? NextDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? NextTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string History { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? QCategory { get; set; }
    }
}