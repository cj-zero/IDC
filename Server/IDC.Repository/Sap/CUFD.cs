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
    public partial class CUFD 
    {
        public CUFD()
        {
          this.AliasID= string.Empty;
          this.Descr= string.Empty;
          this.TypeID= string.Empty;
          this.EditType= string.Empty;
          this.Dflt= string.Empty;
          this.NotNull= string.Empty;
          this.IndexID= string.Empty;
          this.RTable= string.Empty;
          this.Action= string.Empty;
          this.Sys= string.Empty;
          this.DfltDate= DateTime.Now;
          this.RelUDO= string.Empty;
          this.ValidRule= string.Empty;
          this.RelSO= string.Empty;
          this.RThrdPTab= string.Empty;
          this.RThrdPFld= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AliasID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TypeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EditType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SizeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? EditSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Dflt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NotNull { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IndexID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RTable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? RField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Sys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DfltDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RelUDO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ValidRule { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RelSO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RThrdPTab { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RThrdPFld { get; set; }
    }
}