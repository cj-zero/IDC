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
    public partial class CPRF 
    {
        public CPRF()
        {
          this.VisInForm= string.Empty;
          this.EditInForm= string.Empty;
          this.VisInExpnd= string.Empty;
          this.EditInEXP= string.Empty;
          this.Folded= string.Empty;
          this.ExtDisable= string.Empty;
          this.ExtInvsbl= string.Empty;
          this.TableName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VisInForm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? VisualIndx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EditInForm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string VisInExpnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExpandIndx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string EditInEXP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Folded { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtDisable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtInvsbl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TableName { get; set; }
    }
}